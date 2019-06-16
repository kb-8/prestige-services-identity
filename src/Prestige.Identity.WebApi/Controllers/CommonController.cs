using Microsoft.AspNetCore.Mvc;
using System;

namespace Prestige.Identity.WebApi.Controllers
{
    public class CommonController : ControllerBase
    {
        protected Guid UserId
            => string.IsNullOrWhiteSpace(User?.Identity?.Name) ?
                Guid.Empty :
                Guid.Parse(User.Identity.Name);
    }
}