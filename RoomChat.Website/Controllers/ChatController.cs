// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatController.cs" company="">
//   
// </copyright>
// <summary>
//   The chat controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RoomChat.Website.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    ///     The chat controller.
    /// </summary>
    public class ChatController : Controller
    {
        // GET: /Chat/
        #region Public Methods and Operators

        /// <summary>
        ///     The index.
        /// </summary>
        /// <returns>
        ///     The <see cref="ActionResult" />.
        /// </returns>
        public ActionResult AllChatRooms()
        {
            return this.View("AllChatRooms");
        }

        /// <summary>
        /// The my chat rooms.
        /// </summary>
        /// <returns>
        /// The <see cref="ActionResult"/>.
        /// </returns>
        public ActionResult MyChatRooms()
        {
            return this.View("MyChatRooms");
        }

        #endregion
    }
}