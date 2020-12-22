using Calendaris.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendaris.Server.Configuracions
{
    public class CalendariTreballadorConfiguracio : IEntityTypeConfiguration<CalendariTreballador>
    {
        public void Configure(EntityTypeBuilder<CalendariTreballador> builder)
        {
            builder.ToTable("CalendarisTreballador");
            builder.HasKey("Id");
            builder.Property(c => c.Any).HasColumnName("Any").IsRequired();
            builder.Property(c => c.DataConfeccio).HasColumnName("DataConfeccio").HasColumnType("Date").IsRequired();
            builder.Property(c => c.Observacions).HasColumnName("Observacions").HasMaxLength(500).IsUnicode(false);
        }
    }
}
