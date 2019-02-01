using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SolidWorkshop
{
    public abstract class EntitySetBase<TEntity> : IEntitySet<TEntity>
    {
        public Expression Expression => this.Entities.Expression;
  
        public Type ElementType => this.Entities.ElementType;

        public IQueryProvider Provider => this.Entities.Provider;

        protected abstract IQueryable<TEntity> Entities { get; }

        public abstract TEntity Add(TEntity entity);

        public IEnumerator<TEntity> GetEnumerator()
            => this.Entities.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => (this.Entities as IEnumerable).GetEnumerator();
        
    }
}
