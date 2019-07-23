using Newtonsoft.Json;

namespace Prestige.Identity.Infrastructure.Commands
{
    public class SignIn
    {
        public string Email { get; }
        public string Password { get; }

        [JsonConstructor]
        public SignIn(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
