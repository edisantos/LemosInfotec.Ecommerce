using System;
using LemosInfotec.Ecommerce.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LemosInfotec.Ecommerce.Domain.EntityConfig
{
    public class UsuariosConfiguration : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(p=>p.Id); //Chave primaria

            builder.Property(p=>p.Email)
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(x=>x.Senha)
            .HasColumnType("varchar")
            .HasMaxLength(400)
            .IsRequired();

            builder.Property(p=>p.Nome)
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();

            builder.Property(p=>p.SobreNome)
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();

            //builder.Property(x=>x.Pedidos)

            
        }
    }
}
