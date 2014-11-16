// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Room.cs" company="">
//   
// </copyright>
// <summary>
//   The room.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RoomChat.Dalc.Models
{
    using System.Collections.Generic;

    /// <summary>
    ///     The room.
    /// </summary>
    public class Room
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        /// Gets or sets the city id.
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        ///     Gets or sets the joined users.
        /// </summary>
        public virtual ICollection<User> JoinedUsers { get; set; }

        /// <summary>
        ///     Gets or sets the messages.
        /// </summary>
        public virtual ICollection<Message> Messages { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        #endregion
    }
}