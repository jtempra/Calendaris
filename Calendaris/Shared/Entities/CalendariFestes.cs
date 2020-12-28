using Calendaris.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendaris.Shared.Entities
{
    public class CalendariFestes
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Festa { get; set; }
        public TipusFesta Tipus { get; set; }
        public string Observacions { get; set; }
    }
}
