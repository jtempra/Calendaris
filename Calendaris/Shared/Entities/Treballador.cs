using Calendaris.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendaris.Shared.Entities
{
    public class Treballador
    {
        public int Id { get; set; }
        public string Codi { get; set; }
        public string Nom { get; set; }
        public string PrimerCognom  { get; set; }
        public string SegonCognom { get; set; }
        public string NomSencer => Nom + " " + PrimerCognom + " " + SegonCognom;
        public string NIF  { get; set; }
        public string NSS  { get; set; }
        public string Adreça { get; set; }
        public string CP { get; set; }
        public string Poblacio { get; set; }
        public string Provincia { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string Telefon3 { get; set; }
        public string Mobil1 { get; set; }
        public string Mobil2 { get; set; }
        public string Mobil3 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public Centre Centre { get; set; }
        public Departament Departament { get; set; }
        public DateTime DataAlta { get; set; }
        public DateTime? DataBaixa { get; set; }
        public string Observacions { get; set; }
        public List<ConveniTreballador> ConvenisTreballador { get; set; }
        public List<PlantillaCalendari> PlantillaCalendari { get; set; }
        public List<CalendariTreballador> CalendarisTreballador { get; set; }
    }
}
