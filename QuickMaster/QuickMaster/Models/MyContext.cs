using Microsoft.EntityFrameworkCore;

namespace QuickMaster.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Books> Book { get; set; }
    }
}
