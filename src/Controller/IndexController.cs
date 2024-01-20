using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreVersion8.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class IndexController : ControllerBase
	{
		public IndexController()
		{

		}
		public IActionResult Get()
		{
			return Ok("Hellow");
		}
	}
}
