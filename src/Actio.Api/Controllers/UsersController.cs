using Actio.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Actio.Api.Controllers
{
	[Route("[controller")]
	public class UsersController : ControllerBase
	{
		private readonly IBusClient busClient;
		public UsersController(IBusClient busClient)
		{
			this.busClient = busClient;
		}
		[HttpPost("register")]
		public async Task<IActionResult> Post([FromBody]CreateUser command)
		{

			await busClient.PublishAsync(command);
			return Accepted();
		}
	}
}
