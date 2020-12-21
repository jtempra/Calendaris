using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendaris.Shared.Entities
{
    public class ConveniTreballador
    {
        public int ConveniId { get; set; }
        public int TreballadorId { get; set; }
        public Conveni Conveni { get; set; }
        public Treballador Treballador { get; set; }
        public DateTime DataInici { get; set; }
        public DateTime DataFinal { get; set; }
        public string Observacions { get; set; }
    }
}
