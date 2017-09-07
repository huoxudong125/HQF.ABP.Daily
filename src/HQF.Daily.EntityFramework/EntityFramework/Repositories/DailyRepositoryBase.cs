using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace HQF.Daily.EntityFramework.Repositories
{
    public abstract class DailyRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<DailyDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected DailyRepositoryBase(IDbContextProvider<DailyDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class DailyRepositoryBase<TEntity> : DailyRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected DailyRepositoryBase(IDbContextProvider<DailyDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
