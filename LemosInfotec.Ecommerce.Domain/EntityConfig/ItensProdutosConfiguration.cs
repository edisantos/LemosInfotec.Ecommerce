using System;
using LemosInfotec.Ecommerce.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LemosInfotec.Ecommerce.Domain.EntityConfig
{
    public class ItensProdutosConfiguration : IEntityTypeConfiguration<ItensPedidos>
    {
        public void Configure(EntityTypeBuilder<ItensPedidos> builder)
        {
           // throw new NotImplementedException();
           builder.HasKey(x=>x.Id);

           builder.Property(x=>x.Quantidade)
           .HasColumnType("int")
           .IsRequired();

           builder.Property(x=>x.ProdutoId)
           .IsRequired();

        }
    }
}
