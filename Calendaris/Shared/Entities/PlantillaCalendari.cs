using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendaris.Shared.Entities
{
    public class PlantillaCalendari
    {
        public int Id { get; set; }
        public Treballador Treballador { get; set; }
        public DateTime DataInici { get; set; }
        public DateTime? DataFinal { get; set; }
        public string Observacions { get; set; }
        public List<DetallPlantillaCalendari> DetallsPlantillaCalendari { get; set; }
    }
}
