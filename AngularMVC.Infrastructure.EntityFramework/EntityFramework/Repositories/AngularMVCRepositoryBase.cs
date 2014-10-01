using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Repositories.EntityFramework;

namespace AngularMVC.EntityFramework.Repositories
{
    public abstract class AngularMVCRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AngularMVCDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class AngularMVCRepositoryBase<TEntity> : AngularMVCRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
