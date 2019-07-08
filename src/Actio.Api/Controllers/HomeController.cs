using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Actio.Api.Controllers
{
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
		// GET api/values
		[HttpGet]
		public IActionResult Get()
		{
			return Content("Hello from Actio API!");
		}
       
    }
}
