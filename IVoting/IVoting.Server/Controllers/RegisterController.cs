using IVoting.Server.Models.Register;
using IVoting.Server.Provider.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IVoting.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegisterController : Controller
    {

        public IvotingApiProviderInterface _votingApiProvider;

        public RegisterController(IvotingApiProviderInterface ivotingApiProvider)
        {
            _votingApiProvider = ivotingApiProvider;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterHostAsync(
           [FromBody] RegisterRequest request,
           CancellationToken cancellationToken)
        {
            var response = await _votingApiProvider.RegisterHostAsync(request, cancellationToken);

            return Ok(response);
        }
    }
}
