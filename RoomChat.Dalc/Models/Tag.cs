// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tag.cs" company="">
//   
// </copyright>
// <summary>
//   The tag.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RoomChat.Dalc.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The tag.
    /// </summary>
    public class Tag
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Gets or sets the messages.
        /// </summary>
        public virtual ICollection<Message> Messages { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        #endregion
    }
}