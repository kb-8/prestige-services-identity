using Microsoft.EntityFrameworkCore;
using Prestige.Identity.Data.Domain;

namespace Prestige.Identity.Data.DAL
{
    public class PrestigeContext : DbContext 
    {
        public PrestigeContext(DbContextOptions<PrestigeContext> options)
            : base(options)
        { }

        public DbSet<User> User { get; set; }
    }
}
