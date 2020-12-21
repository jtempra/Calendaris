using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendaris.Shared.Entities
{
    public class DetallCalendariTreballador
    {
        public int Id { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public DateTime HoraInici1 { get; set; }
        public DateTime HoraFinal1 { get; set; }
        public DateTime HoraInici2 { get; set; }
        public DateTime HoraFinal2 { get; set; }
        public DateTime HoraInici3 { get; set; }
        public DateTime HoraFinal3 { get; set; }
        public Boolean Vacances { get; set; } = false;
        public string Observacions { get; set; }
        public CalendariTreballador CalendariTreballador { get; set; }
    }
}
