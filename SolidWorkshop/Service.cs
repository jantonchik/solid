using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorkshop.Interfaces;

namespace SolidWorkshop
{
    public class Service : IService<Entity>
    {
        protected readonly IDbConnector<Entity> _SqlConnector;

        public Service(IDbConnector<Entity> connector)
        {
            _SqlConnector = connector;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Save(Entity entity)
        {
            try
            {
                _SqlConnector.Save(entity);          
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Returns an Entities from Repository.
        /// </summary>
        /// <returns> Returns an <see cref="IEnumerable<T>Entity</T>"/>. </returns>
        public IEnumerable<Entity> ReadAll()
        {
            var entitySet = _SqlConnector.GetAll();
            return entitySet;
        }
    }
}
