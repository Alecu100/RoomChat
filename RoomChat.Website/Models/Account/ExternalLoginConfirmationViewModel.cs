// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExternalLoginConfirmationViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   The external login confirmation view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RoomChat.Website.Models.Account
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The external login confirmation view model.
    /// </summary>
    public class ExternalLoginConfirmationViewModel
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        #endregion
    }
}