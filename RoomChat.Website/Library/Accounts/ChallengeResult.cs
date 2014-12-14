// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChallengeResult.cs" company="">
//   
// </copyright>
// <summary>
//   The challenge result.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RoomChat.Website.Library.Accounts
{
    using System.Web;
    using System.Web.Mvc;

    using Microsoft.Owin.Security;

    using RoomChat.Website.Controllers;

    /// <summary>
    ///     The challenge result.
    /// </summary>
    public class ChallengeResult : HttpUnauthorizedResult
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ChallengeResult"/> class.
        /// </summary>
        /// <param name="provider">
        /// The provider.
        /// </param>
        /// <param name="redirectUri">
        /// The redirect uri.
        /// </param>
        public ChallengeResult(string provider, string redirectUri)
            : this(provider, redirectUri, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChallengeResult"/> class.
        /// </summary>
        /// <param name="provider">
        /// The provider.
        /// </param>
        /// <param name="redirectUri">
        /// The redirect uri.
        /// </param>
        /// <param name="userId">
        /// The user id.
        /// </param>
        public ChallengeResult(string provider, string redirectUri, string userId)
        {
            this.LoginProvider = provider;
            this.RedirectUri = redirectUri;
            this.UserId = userId;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets or sets the login provider.
        /// </summary>
        public string LoginProvider { get; set; }

        /// <summary>
        ///     Gets or sets the redirect uri.
        /// </summary>
        public string RedirectUri { get; set; }

        /// <summary>
        ///     Gets or sets the user id.
        /// </summary>
        public string UserId { get; set; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// The execute result.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public override void ExecuteResult(ControllerContext context)
        {
            var properties = new AuthenticationProperties { RedirectUri = this.RedirectUri };
            if (this.UserId != null)
            {
                properties.Dictionary[AccountController.XsrfKey] = this.UserId;
            }

            context.HttpContext.GetOwinContext().Authentication.Challenge(properties, this.LoginProvider);
        }

        #endregion
    }
}