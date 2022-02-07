using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkCoreSample.Models
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().Property(b => b.Name).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Blog>().Property(b => b.Url).HasMaxLength(60);      
            modelBuilder.Entity<Post>().Property(p=>p.Title).HasMaxLength(160).IsRequired();
            modelBuilder.Entity<Blog>().Property<bool>("Deactivated");   
            modelBuilder.Entity<Blog>().Property<int>("LoyaltyPoints");
            modelBuilder.Entity<Blog>().Property<int>("BlogPostCount");
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Blog> Blogs { get; set; }

        public virtual DbSet<Post> Posts { get; set; }
    }
}
