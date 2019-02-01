using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public class CustomEntitySet<TEntity> : EntitySetBase<TEntity> where TEntity : Entity
    {
        private IInternalSet<TEntity> entities;

        public CustomEntitySet(IInternalSet<TEntity> entities)
        {
            this.entities = entities ?? throw new ArgumentNullException(nameof(entities));
        }

        protected override IQueryable<TEntity> Entities => this.entities;


        public override TEntity Add(TEntity entity)
        {
            return this.entities.Add(entity);
        }
    }
}
