using MediatR;
using Post.Application.Features.Post.Queries.GetPostList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Application.Features.Post.Queries.GetPostDetails;
public class GetPostDetailQuery : IRequest<GetPostDetailViewModel>
{
    public Guid PostId { get; set; }
}
