using Microsoft.EntityFrameworkCore;

namespace WebAPIWithDapper.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        private DbSet<Book> Books { get; set; }
    }
}