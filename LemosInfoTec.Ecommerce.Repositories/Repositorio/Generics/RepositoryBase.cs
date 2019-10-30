using System;
using System.Collections.Generic;
using LemosInfotec.Ecommerce.Domain.Contratos;

namespace LemosInfoTec.Ecommerce.Repositories.Repositorio.Generics
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        public RepositoryBase()
        {
            
        }
        public void Adcionar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

       
        public void Excluid(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity GetId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> ListarTodos()
        {
            throw new NotImplementedException();
        }

         public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

}
