using System;
using System.Collections.Generic;
using System.Linq;
using LemosInfotec.Ecommerce.Domain.ObjetosValores;

namespace LemosInfotec.Ecommerce.Domain.Entidades
{
    public class Pedidos:EntidadesGeneric
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public int FormaPagamentoId { get; set; }

        public virtual Usuarios Usuarios{get;set;}
        public virtual FormaPagamento FormaPagamento{get;set;}
        public ICollection<ItensPedidos>ItensPedidos{get;set;}

        public override void Validate()
        {
            LimparMansagem();//Limpar validação
            if(!ItensPedidos.Any()){
                MensagemCritica("Item de Pedidos não pode ser vazio");
                
            }
            
        }
    }
}
