using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Repositories.EntityFramework;

namespace ExtramileManager.EntityFramework.Repositories
{
    public abstract class ExtramileManagerRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ExtramileManagerDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class ExtramileManagerRepositoryBase<TEntity> : ExtramileManagerRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
