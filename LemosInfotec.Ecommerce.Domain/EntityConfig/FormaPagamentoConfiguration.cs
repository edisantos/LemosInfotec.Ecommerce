using System;
using LemosInfotec.Ecommerce.Domain.ObjetosValores;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LemosInfotec.Ecommerce.Domain.EntityConfig
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
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

        }
    }
}
