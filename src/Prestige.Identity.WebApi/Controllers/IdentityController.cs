using Microsoft.AspNetCore.Mvc;
using Prestige.Identity.Common.Commands;

namespace Prestige.Identity.WebApi.Controllers
{
    [Route("")]
    [ApiController]
    public class IdentityController : CommonController
    {
        public IdentityController()
        {
        }

        [HttpPost("sign-in")]
        public IActionResult SignIn(SignIn command)
            => Ok();
    }
}
