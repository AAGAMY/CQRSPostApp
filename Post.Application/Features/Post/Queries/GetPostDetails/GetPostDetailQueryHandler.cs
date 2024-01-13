using AutoMapper;
using MediatR;
using Post.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Application.Features.Post.Queries.GetPostDetails;
public class GetPostDetailQueryHandler : IRequestHandler<GetPostDetailQuery, GetPostDetailViewModel>
{
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;

    public GetPostDetailQueryHandler(IPostRepository postRepository, IMapper mapper)
    {
        _postRepository = postRepository;
        _mapper = mapper;
    }

    public async Task<GetPostDetailViewModel> Handle(GetPostDetailQuery request, CancellationToken cancellationToken)
    {
        var Post = await _postRepository.GetPostByIdAsync(request.PostId, true);
        return _mapper.Map<GetPostDetailViewModel>(Post);
    }
}


