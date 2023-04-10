using System.Data.Entity;

namespace proiect.Models
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
