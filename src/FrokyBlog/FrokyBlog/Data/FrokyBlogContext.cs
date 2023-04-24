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

        public DbSet<Post> Post { get; set; }
    }
}
