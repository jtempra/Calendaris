using Calendaris.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendaris.Server.Configuracions
{
    public class DetallPlantillaCalendariConfiguracio : IEntityTypeConfiguration<DetallPlantillaCalendari>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DetallPlantillaCalendari> builder)
        {
            builder.ToTable("DetallsPlantillaCalendari");
            builder.HasKey("Id");
            builder.Property(d => d.DataInicial).HasColumnName("DataInicial").HasColumnType("Date").IsRequired();
            builder.Property(d => d.DataFinal).HasColumnName("DataFinal").HasColumnType("Date").IsRequired();
            builder.Property(d => d.HoraInici1).HasColumnName("HoraInici1").HasColumnType("DateTime");
            builder.Property(d => d.HoraFinal1).HasColumnName("HoraFinal1").HasColumnType("DateTime");
            builder.Property(d => d.HoraInici2).HasColumnName("HoraInici2").HasColumnType("DateTime");
            builder.Property(d => d.HoraFinal2).HasColumnName("HoraFinal2").HasColumnType("DateTime");
            builder.Property(d => d.HoraInici3).HasColumnName("HoraInici3").HasColumnType("DateTime");
            builder.Property(d => d.HoraFinal3).HasColumnName("HoraFinal3").HasColumnType("DateTime");
            builder.Property(d => d.Vacances).HasColumnName("Vacances").IsRequired();
            builder.Property(d => d.Observacions).HasColumnName("Observacions").HasMaxLength(500).IsUnicode(false);
        }
    }
}
