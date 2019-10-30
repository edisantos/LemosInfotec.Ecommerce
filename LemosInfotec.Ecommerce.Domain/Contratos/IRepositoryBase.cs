using System;
using System.Collections.Generic;

namespace LemosInfotec.Ecommerce.Domain.Contratos
{
    public interface IRepositoryBase<TEntity>: IDisposable where TEntity:class
    {
         void Adcionar(TEntity entity);

         TEntity GetId(int id);
         IEnumerable<TEntity> ListarTodos();
         void Atualizar(TEntity entity);
         void Excluid(TEntity entity);
    }
}