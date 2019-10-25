using System;
using System.Collections.Generic;
using System.Linq;

namespace LemosInfotec.Ecommerce.Domain.Entidades
{
    public abstract class EntidadesGeneric
    {
        public List<string> _mensagemValicao{get;set;}
        public List<string> MensageValidacao{
            get{return _mensagemValicao??(_mensagemValicao =new List<string>());}
        }
        protected void LimparMansagem(){
            MensageValidacao.Clear();
        }
        public abstract void Validate();
        protected bool EhValido{
            get{return!MensageValidacao.Any();}
        }
    }
}
