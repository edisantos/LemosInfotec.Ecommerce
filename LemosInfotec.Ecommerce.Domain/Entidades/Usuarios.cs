using System;
using System.Collections.Generic;
using LemosInfotec.
namespace LemosInfotec.Ecommerce.Domain.Entidades
{
    public class Usuarios:EntidadesGeneric
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public ICollection<Pedidos>Pedidos{get;set;}

        public override void Validate()
        {
            if(string.IsNullOrEmpty(Email)){
                
            }
        }
    }
}
