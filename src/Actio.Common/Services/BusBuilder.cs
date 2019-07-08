using Actio.Common.Commands;
using Actio.Common.Events;
using Actio.Common.RabbitMq;
using Microsoft.AspNetCore.Hosting;
using RawRabbit;
namespace Actio.Common.Services
{
    public class BusBuilder : BuilderBase
    {
        
        private readonly IWebHost webHost;
        private IBusClient bus;
        
        public BusBuilder(IWebHost webHost, IBusClient bus)
        {
            this.webHost = webHost;
            this.bus = bus;
        }

        public BusBuilder SubscribeToCommand<TCommand>()
        {
            var handler = (ICommandHandler<TCommand>)webHost.Services
                .GetService(typeof(ICommandHandler<TCommand>));
                bus.WithCommandHandlerAsync(handler);

                return this;
        }
        public BusBuilder SubscribeToEvent<TEvent>()
        {
            var handler = (IEventHandler<TEvent>)webHost.Services
                .GetService(typeof(IEventHandler<TEvent>));
                bus.WithEventHandlerAsync(handler);

                return this;
        }
        public override ServiceHost Build()
        {
            return new ServiceHost(webHost);
        }
    }
}