using Microsoft.EntityFrameworkCore;
using LicenseMgr.Models.Domain;

namespace LicenseMgr.Data

{
    public class BloggieDbContext : DbContext
    {
        public BloggieDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}

