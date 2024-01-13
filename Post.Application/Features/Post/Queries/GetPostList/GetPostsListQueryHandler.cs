using AutoMapper;
using MediatR;
using Post.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Post.Domain;

namespace Post.Application.Features.Post.Queries.GetPostList;
public class GetPostsListQueryHandler : IRequestHandler<GetPostsListQuery, List<GetPostsListViewModel>>
{
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;

    public GetPostsListQueryHandler(IPostRepository postRepository, IMapper mapper)
    {

        _postRepository = postRepository;
        _mapper = mapper;
    }

    public async Task<List<GetPostsListViewModel>> Handle(GetPostsListQuery request, CancellationToken cancellationToken)
    {
        var allPosts = await _postRepository.GetAllPostsAsync(true);
        return _mapper.Map<List<GetPostsListViewModel>>(allPosts);
    }
}
