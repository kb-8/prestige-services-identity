using System;
using System.Threading.Tasks;

namespace Prestige.Identity.Infrastructure.Services
{
    public interface IIdentityService
    {
        Task SignUpAsync(string name, string email, string password);

        Task SignInAsync(string email, string password);
    }
}
