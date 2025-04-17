using System.Reflection.Metadata;
using Application.Handlers.Register;
using Application.Models.Register;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RegisterController : ControllerBase
	{
		private readonly ILogger<RegisterController> _logger;
		private readonly RegisterHostHandler _registerHostHandler;

		public RegisterController(
			ILogger<RegisterController> logger, 
			RegisterHostHandler registerHostHandler)
		{
			_logger = logger;
			_registerHostHandler = registerHostHandler;
        }

        [HttpPost("host")]
        public async Task<IActionResult> RegisterHostAsync([FromBody] RegisterHostRequest request)
        {
            try
            {
                var result = await _registerHostHandler.HandleAsync(request);
                return Ok(result);
            }
            catch (ValidationException ex)
            {
                return BadRequest(new { ex.Errors });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao registrar o host.");
                return StatusCode(500, "Erro interno do servidor.");
            }
        }
    }
}
