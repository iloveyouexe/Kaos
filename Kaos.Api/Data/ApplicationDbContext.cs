using Kaos.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Kaos.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet properties representing your tables
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<User> User { get; set; }
        // Add more DbSets for other entities
    }
}