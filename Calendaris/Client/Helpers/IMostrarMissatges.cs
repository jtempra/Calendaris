using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendaris.Client.Helpers
{
    public interface IMostrarMissatges
    {
        Task MostrarMissatgeError(string missatge);
        Task MostrarMissatgeExit(string missatge);
    }
}
