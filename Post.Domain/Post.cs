using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Domain;
public class Post
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public Category? Category { get; set; }
    public Guid CategoryId { get; set; }

}

public class Category
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public ICollection<Post>? Blogs { get; set; }

}
