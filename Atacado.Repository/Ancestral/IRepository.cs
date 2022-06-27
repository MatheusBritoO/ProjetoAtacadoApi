using System.Linq.Expressions;

namespace Atacado.Repository.Ancestral
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> Browse(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> Read(int skip = 0, int take = 0);

        TEntity Edit(TEntity obj);

        TEntity Add(TEntity obj);

        TEntity Delete(TEntity obj);

    }
}
