using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Post.Application.Contracts;
public interface IPostRepository : IAsyncRepository<Post.Domain.Post>
{
    Task<IReadOnlyList<Post.Domain.Post>> GetAllPostsAsync(bool includeCategory);
    Task<Post.Domain.Post> GetPostByIdAsync(Guid id, bool includeCategory);
}
