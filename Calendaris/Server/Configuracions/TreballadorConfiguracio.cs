using Calendaris.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendaris.Server.Configuracions
{
    public class TreballadorConfiguracio : IEntityTypeConfiguration<Treballador>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Treballador> builder)
        {
            builder.ToTable("Treballadors");
            builder.HasKey("Id");
            builder.Property(c => c.Codi).HasColumnName("Codi").HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(c => c.Nom).HasColumnName("Nom").HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(c => c.PrimerCognom).HasColumnName("PrimerCognom").HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(c => c.SegonCognom).HasColumnName("SegonCognom").HasMaxLength(50).IsRequired().IsUnicode(false);
            builder.Property(c => c.NIF).HasColumnName("NIF").HasMaxLength(10).IsRequired().IsUnicode(false);
            builder.Property(c => c.NSS).HasColumnName("NSS").HasMaxLength(25).IsUnicode(false);
            builder.Property(c => c.Adreça).HasColumnName("Adreça").HasMaxLength(100).IsUnicode(false);
            builder.Property(c => c.CP).HasColumnName("CP").HasMaxLength(10).IsRequired().IsUnicode(false);
            builder.Property(c => c.Poblacio).HasColumnName("Poblacio").HasMaxLength(50).IsUnicode(false);
            builder.Property(c => c.Provincia).HasColumnName("Provincia").HasMaxLength(50).IsUnicode(false);
            builder.Property(c => c.Telefon1).HasColumnName("Telefon1").HasMaxLength(15).IsUnicode(false);
            builder.Property(c => c.Telefon2).HasColumnName("Telefon2").HasMaxLength(15).IsUnicode(false);
            builder.Property(c => c.Telefon3).HasColumnName("Telefon3").HasMaxLength(15).IsUnicode(false);
            builder.Property(c => c.Mobil1).HasColumnName("Mobil1").HasMaxLength(15).IsUnicode(false);
            builder.Property(c => c.Mobil2).HasColumnName("Mobil2").HasMaxLength(15).IsUnicode(false);
            builder.Property(c => c.Mobil3).HasColumnName("Mobil3").HasMaxLength(15).IsUnicode(false);
            builder.Property(c => c.Email1).HasColumnName("Email1").HasMaxLength(100).IsUnicode(false);
            builder.Property(c => c.Email2).HasColumnName("Email2").HasMaxLength(100).IsUnicode(false);
            builder.Property(c => c.Email3).HasColumnName("Email3").HasMaxLength(100).IsUnicode(false);
            builder.Property(c => c.DataAlta).HasColumnName("DataAlta").IsRequired();
            builder.Property(c => c.DataBaixa).HasColumnName("DataBaixa");
            builder.Property(c => c.Observacions).HasColumnName("Observacions").HasMaxLength(500).IsUnicode(false);
        }
    }
}
