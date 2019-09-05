﻿using DealerService;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Startup))]
namespace DealerService
{
    public class Startup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddSingleton<IDealerBusiness, DealerBusiness>();
                services.AddSingleton<IDealerRepository, DealerRepository>();
            });
        }
    }
}