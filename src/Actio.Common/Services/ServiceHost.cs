using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Actio.Common.Services
{
    public class ServiceHost : IServiceHost
    {
        private readonly IWebHost webHost;

        public ServiceHost(IWebHost webHost)
        {
            this.webHost = webHost;
        }
        public void Run() => webHost.RunAsync();

        public static HostingAbstractionsWebHostBuilderExtensions Create<TStartup> (string[] args) where TStartup : class
        {
            Console.Title = typeof(TStartup).Namespace;
            var config = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();
            var webHostBuilder = WebHost.CreateDefaultBuilder(args)
                .UseConfiguration(config)
                .UseStartup<TStartup>();

                return new HostBuilder(webHostBuilder.Build());
        }
    }
}