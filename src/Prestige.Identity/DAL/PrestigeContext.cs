using Microsoft.EntityFrameworkCore;
using Prestige.Identity.Domain;

namespace Prestige.Identity.DAL
{
    public class PrestigeContext : DbContext 
    {
        public PrestigeContext(DbContextOptions<PrestigeContext> options)
            : base(options)
        { }

        public DbSet<User> User { get; set; }
    }
}
