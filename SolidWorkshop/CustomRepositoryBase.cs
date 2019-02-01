using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    internal abstract class CustomRepositoryBase<TEntity> : IStorage, IRepository<TEntity> where TEntity : class
    {
        protected readonly IEntitySet<TEntity> entitySet;
        protected readonly IConnectionManager connectionManager;

        protected CustomRepositoryBase(IEntitySet<TEntity> entitySet, IConnectionManager connectionManager)
        {
            this.entitySet = entitySet ?? throw new ArgumentNullException(nameof(entitySet));
            this.connectionManager = connectionManager ?? throw new ArgumentNullException(nameof(connectionManager));
        }

        public abstract Task<TEntity> CreateAsync(TEntity entity);
        public abstract Task<TEntity> DeleteAsync(int entityId);
        public abstract Task<IEntitySet<TEntity>> GetAllAsync();
        public abstract Task<IEntitySet<TEntity>> GetAsync(int entityId);
        public abstract Task<int> SaveChangesAsync();
        public abstract Task<TEntity> UpdateAsync(TEntity entity);
    }
}
