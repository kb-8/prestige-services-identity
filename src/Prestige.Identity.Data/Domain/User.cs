using System;

namespace Prestige.Identity.Data.Domain
{
    public class User
    {
        // TODO: Add passwordhasher and save PasswordHash instead of Password in the DB
        public int UserId { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email.ToLowerInvariant();
            Password = password;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
