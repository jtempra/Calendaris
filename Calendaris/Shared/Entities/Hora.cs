using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendaris.Shared.Entities
{
    public class Hora
    {
        public int Hores { get; private set; }
        public int Minuts { get; private set; }

        public Hora(uint h, uint m)
        {
            if (h > 23 || m > 59)
            {
                throw new ArgumentException("Invalid time specified");
            }
            Hores = (int)h; 
            Minuts = (int)m;
        }

        public Hora(DateTime dt)
        {
            Hores = dt.Hour;
            Minuts = dt.Minute;
        }
        public override string ToString()
        {
            return String.Format("{0:00}:{1:00}", this.Hores, this.Minuts);
        }
        public DateTime ToDateTime()
        {
            return new DateTime(1, 1, 1, Hores, Minuts, 0);
        }
    }
}
