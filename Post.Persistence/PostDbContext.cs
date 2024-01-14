using Microsoft.EntityFrameworkCore;
using Posts.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Post.Persistence;
public class PostDbContext : DbContext
{
    public PostDbContext(DbContextOptions<PostDbContext> options) : base(options) { }

    public PostDbContext()
    {
        
    }

    public DbSet<Posts.Domain.Post> Posts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var categoryGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
        var postGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");
        modelBuilder.Entity<Category>().HasData(new Category
        {

            Id = categoryGuid,
            Name = "Technology"

        });

        modelBuilder.Entity<Posts.Domain.Post>().HasData(new Posts.Domain.Post
        {
            Id = postGuid,
            Title = "Create Application Using CQRS and Mediator Patterns",
            Content = "Example using CQRS and Mediator Patterns with Clean Code",
            ImageUrl = "Photo.jpg",
            CategoryId = categoryGuid
        });

        base.OnModelCreating(modelBuilder);
    }
}
