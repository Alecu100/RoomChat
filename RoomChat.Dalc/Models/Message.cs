// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Message.cs" company="">
//   
// </copyright>
// <summary>
//   The message.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RoomChat.Dalc.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The message.
    /// </summary>
    public class Message
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        ///     Gets or sets the poster.
        /// </summary>
        public virtual User Poster { get; set; }

        /// <summary>
        ///     Gets or sets the poster id.
        /// </summary>
        public string PosterId { get; set; }

        /// <summary>
        ///     Gets or sets the room.
        /// </summary>
        public virtual Room Room { get; set; }

        /// <summary>
        ///     Gets or sets the room id.
        /// </summary>
        public long RoomId { get; set; }

        /// <summary>
        ///     Gets or sets the tags.
        /// </summary>
        public virtual ICollection<Tag> Tags { get; set; }

        /// <summary>
        ///     Gets or sets the text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        ///     Gets or sets the time stamp.
        /// </summary>
        public DateTime TimeStamp { get; set; }

        #endregion
    }
}