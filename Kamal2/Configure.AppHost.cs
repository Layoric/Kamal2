[assembly: HostingStartup(typeof(Kamal2.AppHost))]

namespace Kamal2;

public class AppHost() : AppHostBase("Kamal2"), IHostingStartup
{
    public void Configure(IWebHostBuilder builder) => builder
        .ConfigureServices(services => {
            // Configure ASP.NET Core IOC Dependencies
        });

    public override void Configure()
    {
        // Configure ServiceStack, Run custom logic after ASP.NET Core Startup
        SetConfig(new HostConfig {
        });
    }
}