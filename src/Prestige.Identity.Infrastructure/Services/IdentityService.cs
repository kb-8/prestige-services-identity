using Prestige.Identity.Data.Domain;
using Prestige.Identity.Infrastructure.Repositories;
using System;
using System.Threading.Tasks;

namespace Prestige.Identity.Infrastructure.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly IUserRepository _userRepository;

        // TODO: Add busPublisher and jwttoken where is needed

        public IdentityService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task SignUpAsync(string name, string email, string password)
        {
            var user = await _userRepository.GetByEmailAsync(email);

            if (user != null)
            {
                throw new Exception($"Email: '{email}' is already in use.");
            }

            user = new User(name, email, password);
            await _userRepository.AddAsync(user);
            _userRepository.SaveChanges();
        }

        public async Task SignInAsync(string email, string password)
        {
            var user = await _userRepository.GetByEmailAsync(email);

            // TODO: Verify password
        }
    }
}
