// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace RoomChat.Dalc.Initializer
{
    using System.Collections.Generic;

    using RoomChat.Dalc.Models;

    /// <summary>
    ///     The program.
    /// </summary>
    internal class Program
    {
        #region Methods

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            var cities = new List<string> { "Bacau", "Iasi", "Arad", "Bucuresti" };
            using (var dbContext = new DbContext())
            {
                var initializer = new System.Data.Entity.DropCreateDatabaseAlways<DbContext>();
                initializer.InitializeDatabase(dbContext);

                foreach (string city in cities)
                {
                    var cityDb = new City();
                    cityDb.Name = city;
                    dbContext.Cities.Add(cityDb);
                }

                dbContext.SaveChanges();
            }
        }

        #endregion
    }
}