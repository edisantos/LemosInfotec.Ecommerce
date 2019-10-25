using System;
using LemosInfotec.Ecommerce.Domain.Enumerador.cs;

namespace LemosInfotec.Ecommerce.Domain.ObjetosValores
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto{
            get{return Id==(int)FormaPagamentoEnum.FormaPagamentoBoleto; }
        }
        public bool EhCartao{
            get{return Id==(int)FormaPagamentoEnum.FormaPagamentoCartaoCredito;}
        }
        public bool EhDeposito{
            get {return Id==(int)FormaPagamentoEnum.FormaPagamentoDeposito;}
        }
    }
}
