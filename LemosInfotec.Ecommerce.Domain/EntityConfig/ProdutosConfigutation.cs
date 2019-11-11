using System;
using LemosInfotec.Ecommerce.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LemosInfotec.Ecommerce.Domain.EntityConfig
{
    public class ProdutosConfigutation : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder)
        {
            //throw new NotImplementedException();

            builder.HasKey(x=>x.Id);

            builder.Property(x=>x.Nome)
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x=>x.Descricao)
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

            builder.Property(x=>x.Preco)
            .HasColumnType("decimal")
            .IsRequired();
        }
    }
}
