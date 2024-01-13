using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Application.Features.Post.Queries.GetPostList;
public class GetPostsListQuery : IRequest<List<GetPostsListViewModel>>
{

}
