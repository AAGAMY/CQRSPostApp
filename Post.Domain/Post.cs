﻿
namespace Posts.Domain;
public class Post
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public Category? Category { get; set; }
    public Guid CategoryId { get; set; }

}
