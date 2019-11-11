using System;
using JetBrains.Annotations;
using LemosInfotec.Ecommerce.Domain.Entidades;
using LemosInfotec.Ecommerce.Domain.EntityConfig;
using LemosInfotec.Ecommerce.Domain.ObjetosValores;
using Microsoft.EntityFrameworkCore;

namespace LemosInfoTec.Ecommerce.Repositories.DataContexto
{
    public class DbContexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<ItensPedidos> ItensPedidos { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }
        public DbContexto(DbContextOptions options) : base(options)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Mapeamento das class
            builder.ApplyConfiguration(new UsuariosConfiguration());
            builder.ApplyConfiguration(new ProdutosConfigutation());
            builder.ApplyConfiguration(new PedidosConfiguration());
            builder.ApplyConfiguration(new ItensProdutosConfiguration());
            base.OnModelCreating(builder);

           // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }


    }
}
