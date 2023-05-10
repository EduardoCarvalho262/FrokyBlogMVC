using Microsoft.EntityFrameworkCore;
using FrokyBlog.Models;

namespace FrokyBlog.Data
{
    public class FrokyBlogContext : DbContext
    {
        public FrokyBlogContext (DbContextOptions<FrokyBlogContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().Property(p => p.Title).IsRequired().HasColumnType("TEXT");
            modelBuilder.Entity<Post>().Property(p => p.Content).IsRequired().HasColumnType("TEXT");
            modelBuilder.Entity<Post>().Property(p => p.Description).IsRequired().HasColumnType("TEXT");
            modelBuilder.Entity<Post>().Property(p => p.CreatedDate).IsRequired().HasColumnType("TEXT");
        }

        public DbSet<Post> Post { get; set; }
    }
}
