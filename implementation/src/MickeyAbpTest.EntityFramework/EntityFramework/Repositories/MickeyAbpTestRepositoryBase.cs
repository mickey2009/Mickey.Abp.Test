using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MickeyAbpTest.EntityFramework.Repositories
{
    public abstract class MickeyAbpTestRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MickeyAbpTestDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MickeyAbpTestRepositoryBase(IDbContextProvider<MickeyAbpTestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MickeyAbpTestRepositoryBase<TEntity> : MickeyAbpTestRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MickeyAbpTestRepositoryBase(IDbContextProvider<MickeyAbpTestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
