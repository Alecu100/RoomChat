// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ChatController.cs" company="">
//   
// </copyright>
// <summary>
//   The chat controller.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RoomChat.Website.Controllers
{
    using System.Web.Mvc;

    /// <summary>
    ///     The chat controller.
    /// </summary>
    public class ChatController : Controller
    {
        // GET: /Chat/
        #region Public Methods and Operators

        /// <summary>
        ///     The chat.
        /// </summary>
        /// <returns>
        ///     The <see cref="ActionResult" />.
        /// </returns>
        public ActionResult Chat()
        {
            return this.View("Chat");
        }

        /// <summary>
        ///     The index.
        /// </summary>
        /// <returns>
        ///     The <see cref="ActionResult" />.
        /// </returns>
        public ActionResult ChatRooms()
        {
            return this.View("ChatRooms");
        }

        #endregion
    }
}