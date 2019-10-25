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
            if(ProdutoId==0){
                MensagemCritica("Não foi identificado qual a referencia do produto");
            }
            if(Quantidade == 0){
                MensagemCritica("Quantidade não foi informado");
            }
        }
    }
}
