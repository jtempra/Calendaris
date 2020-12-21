using Calendaris.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendaris.Server.Configuracions
{
    public class PlantillaCalendariConfiguracio : IEntityTypeConfiguration<PlantillaCalendari>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<PlantillaCalendari> builder)
        {
            builder.ToTable("PlantillesCalendari");
            builder.HasKey("Id");
            builder.Property(c => c.DataInici).HasColumnName("DataInici").IsRequired();
            builder.Property(c => c.DataFinal).HasColumnName("DataFinal");
            builder.Property(c => c.Observacions).HasColumnName("Observacions").HasMaxLength(500).IsUnicode(false);
        }
    }
}
