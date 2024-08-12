using EntropyAuthApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EntropyAuthApp.Data
{
    public class AuthContext : DbContext
    {
        public AuthContext(DbContextOptions<AuthContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
