using Ebook.Models;
using Microsoft.EntityFrameworkCore;

namespace Ebook
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}
