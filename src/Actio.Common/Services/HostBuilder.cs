using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using RawRabbit;
using RabbitMQ;
namespace Actio.Common.Services
{
    public class HostBuilder : BuilderBase
    {
        private readonly IWebHost webHost;
        private IBusClient bus;
        public HostBuilder(IWebHost webHost)
        {
            this.webHost = webHost;
        }
        public BusBuilder UseRabbitMq() 
        {
            bus = (IBusClient)webHost.Services.GetService(typeof(IBusClient));
            return new BusBuilder(webHost, bus);
        }
            
        public override ServiceHost Build()
        {
            return new ServiceHost(webHost);
        }
    }
}