using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actio.Common.Commands;
using Actio.Common.Events;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using RawRabbit;

namespace Actio.Services.Identity.Handlers
{
    public class CreateActivityHandler : ICommandHandler<CreateActivity>
    {
        private readonly IBusClient busClient;

        public CreateActivityHandler(IBusClient busClient)
        {
            this.busClient = busClient;
        }
        public async Task HandleAsync(CreateActivity command)
        {
            Console.WriteLine($"Creating activity: {command.Name}");
            await busClient.PublishAsync(new ActivityCreated(command.Id,
                command.UserId, command.Category, command.Name));
        }
    }
}
