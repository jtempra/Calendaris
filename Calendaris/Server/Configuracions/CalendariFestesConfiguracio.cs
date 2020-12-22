using Calendaris.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendaris.Server.Configuracions
{
    public class CalendariFestesConfiguracio : IEntityTypeConfiguration<CalendariFestes>
    {
        public void Configure(EntityTypeBuilder<CalendariFestes> builder)
        {
            builder.ToTable("CalendarisFestes");
            builder.HasKey("Id");
            builder.Property(c => c.Data).HasColumnName("Data").HasColumnType("Date").IsRequired();
            builder.Property(c => c.Festa).HasColumnName("Festa").HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(c => c.Tipus).HasColumnName("Tipus").IsRequired();
            builder.Property(c => c.Observacions).HasColumnName("Observacions").HasMaxLength(500).IsUnicode(false);
        }

    }
}
