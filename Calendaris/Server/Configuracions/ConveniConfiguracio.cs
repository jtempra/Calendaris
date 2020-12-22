using Calendaris.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendaris.Server.Configuracions
{
    public class ConveniConfiguracio : IEntityTypeConfiguration<Conveni>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Conveni> builder)
        {
            builder.ToTable("Convenis");
            builder.HasKey("Id");
            builder.Property(c => c.Codi).HasColumnName("Codi").HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(c => c.Nom).HasColumnName("Nom").HasMaxLength(100).IsRequired().IsUnicode(false);
            builder.Property(c => c.HoresAnuals).HasColumnName("HoresAnuals").IsRequired();
            builder.Property(c => c.DataInici).HasColumnName("DataInici").HasColumnType("Date").IsRequired();
            builder.Property(c => c.DataFinal).HasColumnName("DataFinal").HasColumnType("Date");
            builder.Property(c => c.Observacions).HasColumnName("Observacions").HasMaxLength(500).IsUnicode(false);
        }
    }
}
