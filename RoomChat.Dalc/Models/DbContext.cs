// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DbContext.cs" company="">
//   
// </copyright>
// <summary>
//   The room chat db context.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RoomChat.Dalc.Models
{
    using System.Data.Entity;

    using Microsoft.AspNet.Identity.EntityFramework;

    /// <summary>
    ///     The room chat db context.
    /// </summary>
    public class DbContext : IdentityDbContext<User>
    {
        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="DbContext" /> class.
        /// </summary>
        public DbContext()
            : base("RoomChatConnection")
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the cities.
        /// </summary>
        public virtual IDbSet<City> Cities { get; set; }

        /// <summary>
        ///     Gets or sets the messages.
        /// </summary>
        public virtual IDbSet<Message> Messages { get; set; }

        /// <summary>
        ///     Gets or sets the rooms.
        /// </summary>
        public virtual IDbSet<Room> Rooms { get; set; }

        /// <summary>
        ///     Gets or sets the tags.
        /// </summary>
        public virtual IDbSet<Tag> Tags { get; set; }

        #endregion
    }
}