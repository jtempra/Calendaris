using Calendaris.Server.Configuracions;
using Calendaris.Shared.Entities;
using Calendaris.Shared.Enums;
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
            // configurem els camps a les taules SQL

            modelBuilder.ApplyConfiguration(new CalendariFestesConfiguracio());
            modelBuilder.ApplyConfiguration(new CalendariTreballadorConfiguracio());
            modelBuilder.ApplyConfiguration(new ConveniConfiguracio());
            modelBuilder.ApplyConfiguration(new ConveniTreballadorConfiguracio());
            modelBuilder.ApplyConfiguration(new DetallCalendariTreballadorConfiguracio());
            modelBuilder.ApplyConfiguration(new DetallPlantillaCalendariConfiguracio());
            modelBuilder.ApplyConfiguration(new PlantillaCalendariConfiguracio());
            modelBuilder.ApplyConfiguration(new TreballadorConfiguracio());

            // Data seeding

            modelBuilder.Entity<CalendariFestes>().HasData(
                new CalendariFestes { Id = 1, Data = new DateTime(2021, 1, 1), Festa = "Cap d'Any", Tipus = Tipusfesta.Autonomica },
                new CalendariFestes { Id = 2, Data = new DateTime(2021, 1, 6), Festa = "Reis", Tipus = Tipusfesta.Autonomica },
                new CalendariFestes { Id = 3, Data = new DateTime(2021, 4, 2), Festa = "Divendres Sant", Tipus = Tipusfesta.Autonomica },
                new CalendariFestes { Id = 4, Data = new DateTime(2021, 4, 5), Festa = "Dilluns de Pasqua", Tipus = Tipusfesta.Autonomica },
                new CalendariFestes { Id = 5, Data = new DateTime(2021, 5, 1), Festa = "Primer de Maig", Tipus = Tipusfesta.Autonomica },
                new CalendariFestes { Id = 6, Data = new DateTime(2021, 6, 24), Festa = "Sant Joan", Tipus = Tipusfesta.Autonomica },
                new CalendariFestes { Id = 7, Data = new DateTime(2021, 9, 11), Festa = "Diada Nacional de CAT", Tipus = Tipusfesta.Autonomica },
                new CalendariFestes { Id = 8, Data = new DateTime(2021, 10, 12), Festa = "Fiesta Nasiona Nyorda", Tipus = Tipusfesta.Nacional },
                new CalendariFestes { Id = 9, Data = new DateTime(2021, 11, 1), Festa = "Tots Sants", Tipus = Tipusfesta.Autonomica },
                new CalendariFestes { Id = 10, Data = new DateTime(2021, 12, 6), Festa = "Dia de la Constitucion Nyorda", Tipus = Tipusfesta.Nacional },
                new CalendariFestes { Id = 11, Data = new DateTime(2021, 12, 8), Festa = "La Immaculada", Tipus = Tipusfesta.Autonomica },
                new CalendariFestes { Id = 12, Data = new DateTime(2021, 12, 25), Festa = "Nadal", Tipus = Tipusfesta.Autonomica }
            );

            modelBuilder.Entity<Conveni>().HasData(
                new Conveni { Id = 1, Codi = "79002575012007", DataInici = new DateTime (2020,11,30), HoresAnuals = 1600, Nom = "Acció social amb infants, joves, families i d'altres, en situació de risc" },
                new Conveni { Id = 2, Codi = "79002795012009", DataInici = new DateTime(2014,4,30), HoresAnuals = 1500, Nom = "Associacions per discapacitats" },
                new Conveni { Id = 3, Codi = "79001565011999", DataInici = new DateTime(2019,2,7), HoresAnuals = 1250, Nom = "Centres especials de treballadors disminuits fisics o sensorials de Catalunya" }
            );

            modelBuilder.Entity<Treballador>().HasData(
                new Treballador { Id = 1, Nom = "Joan", PrimerCognom = "Lopez", SegonCognom = "Teclas", NIF = "77653456A", NSS = "081234567890", Adreça = "Carrer Badal, 45", CP = "08000", Poblacio = "Barcelona", Provincia = "Barcelona", Telefon1 = "938065434", Mobil1 = "600102030", Email1 = "jlopez@terra.es", Centre = Centre.Barcelona, Departament = Departament.Administracio, DataAlta = new DateTime(2010,1,1) },
                new Treballador { Id = 2, Nom = "Julia", PrimerCognom = "Garcia", SegonCognom = "Vacas", NIF = "67345768B", NSS = "501234567890", Adreça = "Calle los Mañicos, 56", CP = "50000", Poblacio = "Zaragoza", Provincia = "Zaragoza", Telefon1 = "976436574", Mobil1 = "600102030", Email1 = "jgvacas@gmail.com", Centre = Centre.Barcelona, Departament = Departament.Administracio, DataAlta = new DateTime(2010, 1, 1) },
                new Treballador { Id = 3, Nom = "Ramir", PrimerCognom = "Rodriguez", SegonCognom = "Samuel", NIF = "19463891C", NSS = "461234567890", Adreça = "Carrer de les Falles", CP = "46000", Poblacio = "Valencia", Provincia = "Valencia", Telefon1 = "966543546", Mobil1 = "600102030", Email1 = "ramirr@gmail.com", Centre = Centre.Barcelona, Departament = Departament.Administracio, DataAlta = new DateTime(2010, 1, 1) },
                new Treballador { Id = 4, Nom = "Angel", PrimerCognom = "Porrata", SegonCognom = "Pesarrodona", NIF = "47586923D", NSS = "088934675421", Adreça = "", CP = "", Poblacio = "Barcelona", Provincia = "Barcelona", Telefon1 = "938065434", Mobil1 = "600102030", Email1 = "aporrata@hotmail.com", Centre = Centre.Barcelona, Departament = Departament.Compres, DataAlta = new DateTime(2010, 1, 1) },
                new Treballador { Id = 5, Nom = "Isabel", PrimerCognom = "Santisteban", SegonCognom = "Junqueres", NIF = "79583452E", NSS = "084578695473", Adreça = "", CP = "", Poblacio = "Barcelona", Provincia = "Barcelona", Telefon1 = "938065434", Mobil1 = "600102030", Email1 = "isasanti@gmail.com", Centre = Centre.Barcelona, Departament = Departament.Comptabilitat, DataAlta = new DateTime(2010, 1, 1) },
                new Treballador { Id = 6, Nom = "Maria", PrimerCognom = "Poltre", SegonCognom = "Patrixol", NIF = "89562854F", NSS = "086736593712", Adreça = "", CP = "", Poblacio = "Barcelona", Provincia = "Barcelona", Telefon1 = "938065434", Mobil1 = "600102030", Email1 = "mpoltre@fcat.cat", Centre = Centre.Barcelona, Departament = Departament.Informatica, DataAlta = new DateTime(2010, 1, 1) },
                new Treballador { Id = 7, Nom = "Montse", PrimerCognom = "Massanes", SegonCognom = "Ameba", NIF = "10694825G", NSS = "080898786757", Adreça = "", CP = "", Poblacio = "Barcelona", Provincia = "Barcelona", Telefon1 = "938065434", Mobil1 = "600102030", Email1 = "mmassanes@terra.es", Centre = Centre.Barcelona, Departament = Departament.Personal, DataAlta = new DateTime(2010, 1, 1) },
                new Treballador { Id = 8, Nom = "Ignasi", PrimerCognom = "Codina", SegonCognom = "Pujol", NIF = "69372517H", NSS = "085647987809", Adreça = "", CP = "", Poblacio = "Barcelona", Provincia = "Barcelona", Telefon1 = "938065434", Mobil1 = "600102030", Email1 = "Ignasic@diba.cat", Centre = Centre.Barcelona, Departament = Departament.RRHH, DataAlta = new DateTime(2010, 1, 1) },
                new Treballador { Id = 9, Nom = "Hector", PrimerCognom = "Rucol", SegonCognom = "Broquil", NIF = "90785940I", NSS = "083425475900", Adreça = "", CP = "", Poblacio = "Barcelona", Provincia = "Barcelona", Telefon1 = "938065434", Mobil1 = "600102030", Email1 = "hectorruc@gmail.com", Centre = Centre.Barcelona, Departament = Departament.Comptabilitat, DataAlta = new DateTime(2010, 1, 1) },
                new Treballador { Id = 10, Nom = "Victor", PrimerCognom = "Bascara", SegonCognom = "Costa", NIF = "80583760J", NSS = "080808786757", Adreça = "", CP = "", Poblacio = "Barcelona", Provincia = "Barcelona", Telefon1 = "938065434", Mobil1 = "600102030", Email1 = "vbascara@ffc.com", Centre = Centre.Barcelona, Departament = Departament.Personal, DataAlta = new DateTime(2010, 1, 1) }
            );
        }
    }
}
