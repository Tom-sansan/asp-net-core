using Microsoft.EntityFrameworkCore;

namespace QuickMaster_Core3.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        public DbSet<Book> Book { get; set; }
    }
}
