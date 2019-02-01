using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public interface IService<TEntity>
    {
        /// <summary>
        /// Gets all entities type of <typeparamref name="TEntity"/> 
        /// </summary>
        /// <returns><see cref="IEntitySet{TEntity}"/> of entities</returns>
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Adds <paramref name="entity"/> to current set
        /// </summary>
        /// <param name="entity">Entity to add</param>
        /// <returns>Added entity</returns>
        Task<TEntity> AddAsync(TEntity entity);
    }
}
