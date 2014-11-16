// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ViewUsersModel.cs" company="">
//   
// </copyright>
// <summary>
//   The view users.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RoomChat.Website.Models.Account
{
    using System.Collections.Generic;

    using RoomChat.Dalc.Models;

    /// <summary>
    ///     The view users.
    /// </summary>
    public class ViewUsersModel
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the users.
        /// </summary>
        public List<User> Users { get; set; }

        #endregion
    }
}