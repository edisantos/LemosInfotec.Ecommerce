using System;
using JetBrains.Annotations;
using LemosInfotec.Ecommerce.Domain.Entidades;
using LemosInfotec.Ecommerce.Domain.ObjetosValores;
using Microsoft.EntityFrameworkCore;

namespace LemosInfoTec.Ecommerce.Repositories.DataContexto
{
    public class DbContexto:DbContext
    {
        public DbContexto(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Usuarios> Usuarios{get;set;}
        public DbSet<Pedidos> Pedidos{get;set;}
        public DbSet<ItensPedidos> ItensPedidos{get;set;}
        public DbSet<Produtos> Produtos{get;set;}
        public DbSet<FormaPagamento> FormaPagamentos{get;set;}
    }
}
