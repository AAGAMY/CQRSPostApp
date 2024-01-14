using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Post.Application.Contracts;
public interface IPostRepository : IAsyncRepository<Posts.Domain.Post>
{
    Task<IReadOnlyList<Posts.Domain.Post>> GetAllPostsAsync(bool includeCategory);
    Task<Posts.Domain.Post> GetPostByIdAsync(Guid id, bool includeCategory);
}
