using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendaris.Client.Helpers
{
    public class MostrarMissatges : IMostrarMissatges
    {
        private readonly IJSRuntime _js;

        public MostrarMissatges(IJSRuntime js)
        {
            _js = js;
        }

        public async Task MostrarMissatgeError(string miss)
        {
            await MostrarMissatge("Error", miss, "error");
        }

        public async Task MostrarMissatgeExit(string miss)
        {
            await MostrarMissatge("Exit", miss, "èxit");
        }

        private async ValueTask MostrarMissatge(string titol, string miss, string tipusMiss)
        {
            await _js.InvokeVoidAsync("Swal.fire", titol, miss, tipusMiss);
        }
    }
}
