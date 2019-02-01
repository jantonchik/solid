using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    internal class CustomSqlRepository : CustomRepositoryBase<Entity>
    {
        public CustomSqlRepository(IEntitySet<Entity> entitySet, IConnectionManager connectionManager) : base(entitySet, connectionManager)
        {
            this.connectionManager.CreateConnection();
        }

        public async override Task<Entity> CreateAsync(Entity entity)
        {
            //kinda implementation of creating
            await this.connectionManager.OpenAsync();
            
            
            // ...
            this.connectionManager.Close();
            throw new NotImplementedException();
            //
        }

        public override Task<Entity> DeleteAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public override Task<IEntitySet<Entity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<IEntitySet<Entity>> GetAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public override Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public override Task<Entity> UpdateAsync(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
