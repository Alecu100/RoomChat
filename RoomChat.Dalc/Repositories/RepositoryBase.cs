// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RepositoryBase.cs" company="">
//   
// </copyright>
// <summary>
//   The repository base.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RoomChat.Dalc.Repositories
{
    using RoomChat.Dalc.Models;

    /// <summary>
    ///     The repository base.
    /// </summary>
    public class RepositoryBase
    {
        #region Fields

        /// <summary>
        ///     The _db context.
        /// </summary>
        private readonly DbContext dbContext;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryBase"/> class.
        /// </summary>
        /// <param name="dbContext">
        /// The db context.
        /// </param>
        public RepositoryBase(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the db context.
        /// </summary>
        public DbContext DbContext
        {
            get
            {
                return this.dbContext;
            }
        }

        #endregion
    }
}