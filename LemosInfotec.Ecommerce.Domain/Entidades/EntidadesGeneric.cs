using System;
using System.Collections.Generic;
using System.Linq;

namespace LemosInfotec.Ecommerce.Domain.Entidades
{
    public abstract class EntidadesGeneric
    {
        private List<string> _mensagemValidacao{get;set;}
        private List<string> mensageValidacao{
            get{return _mensagemValidacao??(_mensagemValidacao =new List<string>());}
        }
        protected void LimparMansagem(){
            mensageValidacao.Clear();
        }
        protected void MensagemCritica(string mensagem){
          mensageValidacao.Add(mensagem);
        }
        public abstract void Validate();
        protected bool EhValido{
            get{return!mensageValidacao.Any();}
        }
    }
}
