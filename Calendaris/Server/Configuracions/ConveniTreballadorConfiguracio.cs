using Calendaris.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendaris.Server.Configuracions
{
    public class ConveniTreballadorConfiguracio : IEntityTypeConfiguration<ConveniTreballador>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ConveniTreballador> builder)
        {
            builder.ToTable("ConvenisTreballador");
            builder.HasKey(c=> new { c.ConveniId, c.TreballadorId});
            builder.Property(c => c.DataInici).HasColumnName("DataInici").IsRequired();
            builder.Property(c => c.DataFinal).HasColumnName("DataFinal");
            builder.Property(c => c.Observacions).HasColumnName("Observacions").HasMaxLength(500).IsUnicode(false);
        }
    }
}
