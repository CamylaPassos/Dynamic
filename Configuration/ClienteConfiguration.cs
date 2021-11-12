using Dynamic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dynamic.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente", "mechanics")
                .HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int(11)");

            builder.Property(x => x.Nome)
               .IsRequired()
               .HasColumnName("Nome")
               .HasColumnType("varchar(100)");

            builder.Property(x => x.Cpf)
               .IsRequired()
               .HasColumnName("Cpf")
               .HasColumnType("varchar(11)");

            builder.Property(x => x.DataNascimento)
               .IsRequired()
               .HasColumnName("Data_Nascimento")
               .HasColumnType("datetime");

            builder.Property(x => x.Sexo)
               .IsRequired()
               .HasColumnName("Sexo")
               .HasColumnType("enum('M','F')");

            builder.Property(x => x.Email)
               .IsRequired()
               .HasColumnName("Email")
               .HasColumnType("varchar(100)");

        }
    }
}
