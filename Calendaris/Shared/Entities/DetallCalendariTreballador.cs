using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Calendaris.Shared.Entities
{
    public class DetallCalendariTreballador
    {
        public int Id { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        [JsonConverter(typeof(JsonTimeSpanConverter))]
        public TimeSpan HoraInici1 { get; set; }
        [JsonConverter(typeof(JsonTimeSpanConverter))]
        public TimeSpan HoraFinal1 { get; set; }
        [JsonConverter(typeof(JsonTimeSpanConverter))]
        public TimeSpan HoraInici2 { get; set; }
        [JsonConverter(typeof(JsonTimeSpanConverter))]
        public TimeSpan HoraFinal2 { get; set; }
        [JsonConverter(typeof(JsonTimeSpanConverter))]
        public TimeSpan HoraInici3 { get; set; }
        [JsonConverter(typeof(JsonTimeSpanConverter))]
        public TimeSpan HoraFinal3 { get; set; }
        public Boolean Vacances { get; set; }
        public string Observacions { get; set; }
        public CalendariTreballador CalendariTreballador { get; set; }
    }
}
