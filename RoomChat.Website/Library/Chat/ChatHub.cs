// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatHub.cs" company="">
//   
// </copyright>
// <summary>
//   The chat hub.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RoomChat.Website.Library.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Web;

    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.SignalR;
    using Microsoft.Owin.Security;

    using RoomChat.Dalc.Models;

    /// <summary>
    ///     The chat hub.
    /// </summary>
    public class ChatHub : Hub
    {
        #region Fields

        /// <summary>
        ///     The connected users.
        /// </summary>
        private readonly List<User> connectedUsers = new List<User>();

        /// <summary>
        ///     The current message.
        /// </summary>
        private readonly List<Message> currentMessages = new List<Message>();

        /// <summary>
        ///     The db context.
        /// </summary>
        private readonly DbContext dbContext = new DbContext();

        /// <summary>
        ///     The user connections.
        /// </summary>
        private readonly List<Connection> userConnections = new List<Connection>();

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the authentication manager.
        /// </summary>
        public IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.Current.GetOwinContext().Authentication;
            }
        }

        /// <summary>
        ///     Gets the current user.
        /// </summary>
        public User CurrentUser
        {
            get
            {
                string userId = this.AuthenticationManager.User.Identity.GetUserId();

                User user = this.connectedUsers.FirstOrDefault(u => u.Id == userId);

                if (user == null)
                {
                    user = (from u in this.dbContext.Users where u.Id == userId select u).First();
                }

                return user;
            }
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The connect.
        /// </summary>
        public void Connect()
        {
            string id = this.Context.ConnectionId;

            if (this.userConnections.Count(x => x.ConnectionHubId == id) == 0)
            {
                User currentUser = this.CurrentUser;

                this.connectedUsers.Add(currentUser);

                this.userConnections.Add(
                    new Connection
                        {
                            ConnectionHubId = this.Context.ConnectionId, 
                            UserId = currentUser.Id, 
                            TimeStamp = DateTime.UtcNow, 
                            User = currentUser
                        });

                // send to caller
                this.Clients.Caller.onConnected(id, currentUser.Id, this.connectedUsers, this.currentMessages);

                // send to all except caller client
                this.Clients.AllExcept(id).onNewUserConnected(id, currentUser.Id);
            }
        }

        /// <summary>
        /// The on disconnected.
        /// </summary>
        /// <param name="stopCalled">
        /// The stop Called.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public override Task OnDisconnected(bool stopCalled)
        {
            Connection item = this.userConnections.FirstOrDefault(x => x.ConnectionHubId == this.Context.ConnectionId);
            if (item != null)
            {
                this.connectedUsers.Remove(item.User);

                this.userConnections.Remove(item);

                string id = this.Context.ConnectionId;
                this.Clients.All.onUserDisconnected(id, item.User.Id);
            }

            return base.OnDisconnected(stopCalled);
        }

        /// <summary>
        /// The send message to all.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        public void SendMessageToAll(string message)
        {
            // store last 100 messages in cache
            this.AddMessageinCache(message);

            // Broad cast message
            this.Clients.All.messageReceived(this.CurrentUser.UserName, message);
        }

        /// <summary>
        /// The send private message.
        /// </summary>
        /// <param name="toUserId">
        /// The to user id.
        /// </param>
        /// <param name="message">
        /// The message.
        /// </param>
        public void SendPrivateMessage(string toUserId, string message)
        {
            User toUser = this.userConnections.First(x => x.UserId == toUserId).User;
            User fromUser = this.CurrentUser;

            if (toUser != null && fromUser != null)
            {
                // send to 
                this.Clients.Client(toUserId).sendPrivateMessage(fromUser.UserName, message);

                // send to caller user
                this.Clients.Caller.sendPrivateMessage(toUserId, fromUser.UserName, message);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// The add messagein cache.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        private void AddMessageinCache(string message)
        {
            User currentUser = this.CurrentUser;

            this.currentMessages.Add(
                new Message { TimeStamp = DateTime.Now, Text = message, PosterId = currentUser.Id });

            if (this.currentMessages.Count > 100)
            {
                this.currentMessages.RemoveAt(0);
            }
        }

        #endregion
    }
}