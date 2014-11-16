// --------------------------------------------------------------------------------------------------------------------
// <copyright file="User.cs" company="">
//   
// </copyright>
// <summary>
//   The application user.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RoomChat.Dalc.Models
{
    using System.Collections.Generic;

    using Microsoft.AspNet.Identity.EntityFramework;

    /// <summary>
    ///     The user.
    /// </summary>
    public class User : IdentityUser
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the age.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        ///     Gets or sets the city.
        /// </summary>
        public virtual City City { get; set; }

        /// <summary>
        ///     Gets or sets the city id.
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// Gets or sets the display image.
        /// </summary>
        public string DisplayImage { get; set; }

        /// <summary>
        ///     Gets or sets the messages.
        /// </summary>
        public virtual ICollection<Message> Messages { get; set; }

        #endregion
    }
}