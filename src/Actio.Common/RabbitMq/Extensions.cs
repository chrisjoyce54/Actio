/// ---------------------------------------------------------------------------
/// <copyright file="Extensions.cs" company="Jack Henry &amp; Associates, Inc.">
///     Copyright (c) 1999-2019,, Jack Henry &amp; Associates, Inc. All Rights Reserved.
/// </copyright>
/// <author>Jack Henry &amp; Associates, Inc.</author>
/// <date>Created:  7/8/2019 11:50:21 AM</date>
/// <summary>"Extensions.cs" is part of "Actio.Common.RabbitMq".  
/// </summary>
/// ---------------------------------------------------------------------------

namespace Actio.Common.RabbitMq
{
	using Actio.Common.Commands;
	using Actio.Common.Events;
	using RawRabbit;
	using RawRabbit.Pipe;
	using System;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Text;
	using System.Threading.Tasks;

	public static class Extensions
	{
		public static Task WithCommandHandlerAsync<TCommand>(this IBusClient bus, ICommandHandler<TCommand> handler)
			=> bus.SubscribeAsync<TCommand>(msg => handler.HandleAsync(msg),
				ctx => ctx.UseSubscribeConfiguration(cfg => cfg.FromDeclaredQueue(q => q.WithName(GetQueueName<TCommand>()))));

		public static Task WithEventHandlerAsync<TEvent>(this IBusClient bus, IEventHandler<TEvent> handler)
			=> bus.SubscribeAsync<TEvent>(msg => handler.HandleAsync(msg),
				ctx => ctx.UseSubscribeConfiguration(cfg => cfg.FromDeclaredQueue(q => q.WithName(GetQueueName<TEvent>()))));

		private static string GetQueueName<T>()
			=> $"{Assembly.GetEntryAssembly().GetName()}/{typeof(T).Name}";
	}
}
