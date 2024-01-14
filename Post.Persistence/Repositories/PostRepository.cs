using Microsoft.EntityFrameworkCore;
using Post.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Persistence.Repositories;
public class PostRepository : BaseRepository<Posts.Domain.Post>, IPostRepository
{
    public PostRepository(PostDbContext postDbContext) : base(postDbContext)
    {

    }

    public async Task<IReadOnlyList<Posts.Domain.Post>> GetAllPostsAsync(bool includeCategory)
    {
        List<Posts.Domain.Post> allPosts = new List<Posts.Domain.Post>();
        allPosts = includeCategory ? await _context.Posts.Include(x => x.Category).ToListAsync() : await _context.Posts.ToListAsync();
        return allPosts;
    }

    public async Task<Posts.Domain.Post> GetPostByIdAsync(Guid id, bool includeCategory)
    {
        Posts.Domain.Post Post = new ();
        Post = includeCategory ? await _context.Posts.Include(x => x.Category).FirstOrDefaultAsync(x => x.Id == id) : await GetByIdAsync(id);
        return Post;
    }
}
