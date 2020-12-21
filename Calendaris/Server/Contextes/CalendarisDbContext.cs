using Calendaris.Server.Configuracions;
using Calendaris.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendaris.Server.Contextes
{
    public class CalendarisDbContext : DbContext
    {
        public CalendarisDbContext(DbContextOptions<CalendarisDbContext> options) : base(options)
        {
        }

        public virtual DbSet<CalendariFestes> CalendarisFestes { get; set; }
        public virtual DbSet<CalendariTreballador> CalendarisTreballador { get; set; }
        public virtual DbSet<Conveni> Convenis { get; set; }
        public virtual DbSet<ConveniTreballador> ConvenisTreballador { get; set; }
        public virtual DbSet<DetallCalendariTreballador> DetallsCalendatisTreballador { get; set; }
        public virtual DbSet<DetallPlantillaCalendari> DetallsPlantillesCalendari { get; set; }
        public virtual DbSet<PlantillaCalendari> PlantillesCalendari { get; set; }
        public virtual DbSet<Treballador> Treballadors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CalendariFestesConfiguracio());
            modelBuilder.ApplyConfiguration(new CalendariTreballadorConfiguracio());
            modelBuilder.ApplyConfiguration(new ConveniConfiguracio());
            modelBuilder.ApplyConfiguration(new ConveniTreballadorConfiguracio());
            modelBuilder.ApplyConfiguration(new DetallCalendariTreballadorConfiguracio());
            modelBuilder.ApplyConfiguration(new DetallPlantillaCalendariConfiguracio());
            modelBuilder.ApplyConfiguration(new PlantillaCalendariConfiguracio());
            modelBuilder.ApplyConfiguration(new TreballadorConfiguracio());
        }
    }
}
