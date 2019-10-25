using System;

namespace LemosInfotec.Ecommerce.Domain.Entidades
{
    public class Produtos:EntidadesGeneric
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
           
            throw new NotImplementedException();
        }
    }
}
