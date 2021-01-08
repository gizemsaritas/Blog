using System.Collections.Concurrent;
using BlogAPI.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using BlogAPI.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
namespace BlogAPI.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class BlogContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = 192.168.0.120, 11433;Initial Catalog = test; User ID = dba; Password = S+dba+142");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new BlogMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CategoryBlogMap());            
            modelBuilder.ApplyConfiguration(new CommentMap());
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryBlog> CategoryBlogs { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}