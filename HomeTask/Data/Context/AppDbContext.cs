using HomeTask.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeTask.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) 
        {

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
