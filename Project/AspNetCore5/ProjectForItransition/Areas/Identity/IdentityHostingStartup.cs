using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(ProjectForItransition.Areas.Identity.IdentityHostingStartup))]
namespace ProjectForItransition.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}