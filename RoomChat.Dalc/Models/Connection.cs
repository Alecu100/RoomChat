// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Connection.cs" company="">
//   
// </copyright>
// <summary>
//   The connection.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RoomChat.Dalc.Models
{
    using System;

    /// <summary>
    ///     The connection.
    /// </summary>
    public class Connection
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the connection hub id.
        /// </summary>
        public string ConnectionHubId { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        ///     Gets or sets the room.
        /// </summary>
        public virtual Room Room { get; set; }

        /// <summary>
        ///     Gets or sets the room id.
        /// </summary>
        public long RoomId { get; set; }

        /// <summary>
        ///     Gets or sets the time stamp.
        /// </summary>
        public DateTime TimeStamp { get; set; }

        /// <summary>
        ///     Gets or sets the user.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        ///     Gets or sets the user id.
        /// </summary>
        public string UserId { get; set; }

        #endregion
    }
}