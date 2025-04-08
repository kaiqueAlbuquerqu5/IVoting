using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RegisterController : ControllerBase
	{
		private readonly ILogger<RegisterController> _logger;

		public RegisterController(ILogger<RegisterController> logger)
		{
			_logger = logger;
		}

		[HttpPost("host/register")]
		public int Get()
		{
			return 4;
		}
	}
}
