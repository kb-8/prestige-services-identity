using Prestige.Identity.Data.Domain;
using System.Threading.Tasks;

namespace Prestige.Identity.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByEmailAsync(string email);

        Task AddAsync(User user);

        void SaveChanges();
    }
}
