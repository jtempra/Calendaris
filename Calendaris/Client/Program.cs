using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Blazor;
using Calendaris.Client.Repos;
using Calendaris.Client.Helpers;

namespace Calendaris.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzcxNDA3QDMxMzgyZTM0MmUzMFc0WnkxTTh0ODlPbzNreDdPbGlPUFVGSkJRSlNDWis4eEYzUExNV3ZaWXM9");

            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            
            builder.Services.AddSyncfusionBlazor();

            ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IRepositori, Repositori>();
            services.AddScoped<IMostrarMissatges, MostrarMissatges>();
        }
    }
}
