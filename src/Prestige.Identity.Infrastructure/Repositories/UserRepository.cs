using Microsoft.EntityFrameworkCore;
using Prestige.Identity.Data.DAL;
using Prestige.Identity.Data.Domain;
using System.Threading.Tasks;

namespace Prestige.Identity.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(IdentityDbContext context)
        {
            this.Context = context;
            this.Users = this.Context.Set<User>();
        }

        private IdentityDbContext Context { get; }

        private DbSet<User> Users { get; }

        public async Task AddAsync(User user)
        {
            await this.Users.AddAsync(user);
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await this.Users.FirstOrDefaultAsync<User>(u => u.Email == email);
        }

        public void SaveChanges()
        {
            this.Context.SaveChanges();
        }
    }
}
