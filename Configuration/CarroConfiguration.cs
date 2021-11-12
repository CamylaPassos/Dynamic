using Dynamic.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dynamic.Configuration
{
    public class CarroConfiguration : IEntityTypeConfiguration<Carro>
    {
        public void Configure(EntityTypeBuilder<Carro> builder)
        {
            builder.ToTable("Carro", "mechanics")
                .HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("Id")
                .HasColumnType("int(11)");

            _ = builder.Property(x => x.Marca)
               .IsRequired()
               .HasColumnName("Marca")
               .HasColumnType("varchar(100)");

            _ = builder.Property(x => x.Modelo)
              .IsRequired()
              .HasColumnName("Modelo")
              .HasColumnType("varchar(100)");


        }
    }
}
