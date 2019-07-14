using Microsoft.EntityFrameworkCore;
using Prestige.Identity.Data.DAL;
using Prestige.Identity.Data.Domain;
using System.Threading.Tasks;

namespace Prestige.Identity.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(PrestigeContext context)
        {
            this.Context = context;
            this.DbSet = this.Context.Set<User>();
        }

        private PrestigeContext Context { get; }

        private DbSet<User> DbSet { get; }

        public async Task AddAsync(User user)
        {
            await this.DbSet.AddAsync(user);
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await this.DbSet.FirstOrDefaultAsync<User>(u => u.Email == email);
        }

        public void SaveChanges()
        {
            this.Context.SaveChanges();
        }
    }
}
