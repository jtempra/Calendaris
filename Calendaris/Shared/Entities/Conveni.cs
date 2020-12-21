using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendaris.Shared.Entities
{
    public class Conveni
    {
        public int Id { get; set; }
        public string Codi { get; set; }
        public string Nom { get; set; }
        public int HoresAnuals { get; set; }
        public DateTime DataInici { get; set; }
        public DateTime DataFinal { get; set; }
        public string Observacions { get; set; }
        public List<ConveniTreballador> Convenistreballador { get; set; }
    }
}
