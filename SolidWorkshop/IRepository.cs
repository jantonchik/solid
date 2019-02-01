using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public interface IRepository<TEntity>
    {
        Task<IEntitySet<TEntity>> GetAllAsync();
        Task<IEntitySet<TEntity>> GetAsync(int entityId);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(int entityId);
    }
}
