using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Atacado.Repository.Ancestral
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        protected DbContext context;

        public BaseRepository(DbContext context)
        {
            this.context = context;
        }

        public TEntity Add(TEntity obj)
        {
            this.context.Set<TEntity>().Add(obj);
            this.context.SaveChanges();
            return obj;
        }

        public IQueryable<TEntity> Browse(Expression<Func<TEntity, bool>> predicate)
        {
            return this.context.Set<TEntity>().Where(predicate);
        }

        public TEntity Delete(TEntity obj)
        {
            this.context.Set<TEntity>().Remove(obj);
            this.context.SaveChanges();
            return obj;
        }

        public abstract TEntity DeleteById(int id);

        public TEntity Edit(TEntity obj)
        {
            this.context.Set<TEntity>().Attach(obj);
            this.context.Entry(obj).State = EntityState.Modified;
            this.context.SaveChanges();
            return obj;

        }

        public IEnumerable<TEntity> Read(int skip = 0, int take = 0)
        {
            if ((skip == 0) && (take == 0))
            {
                return this.context.Set<TEntity>().AsEnumerable();
            }
            else
            {
                return this.context.Set<TEntity>().Skip(skip).Take(take).AsEnumerable();
            }
        }

        public virtual TEntity Read(int id)
        {
            return this.context.Set<TEntity>().Find(id);
        }
        
    }
}
