using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public interface IEntitySet<TEntity> : IQueryable<TEntity>
    {
        /// <summary>
        /// Adds <paramref name="entity"/> to set
        /// </summary>
        /// <param name="entity">Entity to add</param>
        /// <returns>Added entity</returns>
        TEntity Add(TEntity entity);

    }
}
