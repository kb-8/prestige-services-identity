using Microsoft.AspNetCore.Mvc;
using Prestige.Identity.Common.Commands;
using Prestige.Identity.Infrastructure.Services;
using System.Threading.Tasks;

namespace Prestige.Identity.WebApi.Controllers
{
    [Route("identity")]
    [ApiController]
    public class IdentityController : CommonController
    {
        private readonly IIdentityService _identityService;

        public IdentityController(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        [HttpPost("sign-up")]
        public async Task<IActionResult> SignUp(SignUp command)
        {
            await _identityService.SignUpAsync(command.Name, command.Email, command.Password);

            return NoContent();
        }

        [HttpPost("sign-in")]
        public async Task<IActionResult> SignIn(SignIn command)
        {
            await _identityService.SignInAsync(command.Email, command.Password);

            return Ok();
        }
    }
}
