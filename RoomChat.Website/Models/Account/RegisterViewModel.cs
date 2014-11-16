// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RegisterViewModel.cs" company="">
//   
// </copyright>
// <summary>
//   The register view model.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RoomChat.Website.Models.Account
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Web;

    using RoomChat.Dalc.Models;

    /// <summary>
    ///     The register view model.
    /// </summary>
    public class RegisterViewModel
    {
        #region Public Properties

        /// <summary>
        ///     Sets the cities.
        /// </summary>
        public IEnumerable<City> Cities { get; set; }

        /// <summary>
        ///     Gets or sets the city.
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Please select a city!")]
        [DisplayName("City")]
        public int City { get; set; }

        /// <summary>
        ///     Gets or sets the confirm password.
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        /// <summary>
        ///     Gets or sets the avatar.
        /// </summary>
        [DisplayName("Display Image")]
        public HttpPostedFileBase DisplayImage { get; set; }

        /// <summary>
        ///     Gets or sets the password.
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        /// <summary>
        ///     Gets or sets the user name.
        /// </summary>
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        #endregion
    }
}