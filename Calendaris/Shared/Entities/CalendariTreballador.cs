using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendaris.Shared.Entities
{
    public class CalendariTreballador
    {
        public int Id { get; set; }
        public Treballador Treballador { get; set; }
        public int Any { get; set; }
        public DateTime DataConfeccio { get; set; }
        public Boolean Actiu { get; set; }
        public string Observacions { get; set; }
        public List<DetallCalendariTreballador> DetallCalendariTreballador { get; set; }
    }
}
