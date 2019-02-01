using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    internal class CustomService : IService<Entity>
    {
        private readonly IRepository<Entity> repository;

        public CustomService(IRepository<Entity> repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Entity> AddAsync(Entity entity)
        {
            return await this.repository.CreateAsync(entity);
        }

        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return ((await this.repository.GetAllAsync()) as IQueryable<Entity>).ToList();
        }
    }
}
