using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using SolidWorkshop.Interfaces;

namespace SolidWorkshop
{
    public class Repository : IDbConnector<Entity>
    {
        private IDbConnection _conection;

        /// <summary>
        /// Setting the connection with DataBase whlie creating a Repositry.
        /// </summary>
        /// <param name="conection"></param>
        public Repository(IDbConnection conection)
        {
            _conection = conection;
        }

        /// <summary>
        /// Gets all Entities form DataBase.
        /// </summary>
        /// <returns> Returns an <see cref="IEnumerable<T>Entity</T>"/>. </returns>
        public IEnumerable<Entity> GetAll()
        {
            using (_conection)
            {
                try
                {
                    _conection.Open();

                    // perform get

                    return new List<Entity>();
                }
                catch (DbException dbEx)
                {
                    throw new Exception("Something goes wrong with DataBase operations. ", dbEx);
                }
            }
        }

        /// <summary>
        /// Saving the entity into the DataBase.
        /// </summary>
        /// <param name="item"> Object that need to be saved. </param>
        public void Save(Entity item)
        {
            using (_conection)
            {
                try
                {
                    _conection.Open();

                    // perform save
                }
                catch (DbException dbEx)
                {
                    throw new Exception("Something goes wrong with DataBase operations. ", dbEx);
                }
            }
        }
    }
}