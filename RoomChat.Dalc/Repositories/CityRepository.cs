// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CityRepository.cs" company="">
//   
// </copyright>
// <summary>
//   The city repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RoomChat.Dalc.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using RoomChat.Dalc.Models;

    /// <summary>
    ///     The city repository.
    /// </summary>
    public class CityRepository : RepositoryBase
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CityRepository"/> class.
        /// </summary>
        /// <param name="dbContext">
        /// The db context.
        /// </param>
        public CityRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        ///     The get all cities.
        /// </summary>
        /// <returns>
        ///     The <see cref="List" />.
        /// </returns>
        public List<City> GetAllCities()
        {
            IQueryable<City> citites = from city in this.DbContext.Cities select city;
            return citites.ToList();
        }

        #endregion
    }
}