using Newtonsoft.Json;

namespace Prestige.Identity.Common.Commands
{
    public class SignUp
    {
        public string Name { get; }
        public string Email { get; }
        public string Password { get; }

        [JsonConstructor]
        public SignUp(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }
    }
}
