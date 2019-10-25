using System;

namespace LemosInfotec.Ecommerce.Domain.Entidades
{
    public class ItensPedidos:EntidadesGeneric
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
