using Microsoft.EntityFrameworkCore;
using Prestige.Identity.Data.Domain;

namespace Prestige.Identity.Data.DAL
{
    public class IdentityDbContext : DbContext 
    {
        public IdentityDbContext(DbContextOptions<IdentityDbContext> options)
            : base(options)
        { }

        public DbSet<User> User { get; set; }
    }
}
