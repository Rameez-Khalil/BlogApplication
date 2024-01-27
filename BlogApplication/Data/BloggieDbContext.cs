using BlogApplication.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogApplication.Data
{
    // This class inherits DbContext class.
    public class BloggieDbContext : DbContext
    {
        // DBContext Options constructors.
        // We will pass the options to the base class.
        // Two props are required, Blog and Tags.
        public BloggieDbContext(DbContextOptions options) : base(options)
        {
        }

        // These props will be used to create a table in our DB.
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
