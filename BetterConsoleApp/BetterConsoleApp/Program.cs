using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace BetterConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IMyService, MyService>();
                })
                .Build();
            var service = ActivatorUtilities.CreateInstance<GreetingService>(host.Services);
            service.Run();
        }
    }
}
