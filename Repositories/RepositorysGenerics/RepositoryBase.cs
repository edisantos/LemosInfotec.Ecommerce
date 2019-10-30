using System;

namespace Repositories.RepositorysGenerics
{
    public class RepositoryBase<TEntity>:IRepositoryBase<TEntity> where TEntity:class
    {
    }
}
