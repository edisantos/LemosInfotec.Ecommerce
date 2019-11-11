using System;
using LemosInfotec.Ecommerce.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LemosInfotec.Ecommerce.Domain.EntityConfig
{
    public class PedidosConfiguration : IEntityTypeConfiguration<Pedidos>
    {
        public void Configure(EntityTypeBuilder<Pedidos> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.DataPedido)
            .HasColumnType("datetime")
            .IsRequired();
        }
    }
}
