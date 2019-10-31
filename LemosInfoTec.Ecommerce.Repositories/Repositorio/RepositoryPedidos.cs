using System;
using LemosInfotec.Ecommerce.Domain.Contratos;
using LemosInfotec.Ecommerce.Domain.Entidades;
using LemosInfoTec.Ecommerce.Repositories.Repositorio.Generics;

namespace LemosInfoTec.Ecommerce.Repositories.Repositorio
{
    public class RepositoryPedidos:RepositoryBase<Pedidos>,IRepositoryPedidos
    {
        public RepositoryPedidos()
        {
            
        }
    }
}
