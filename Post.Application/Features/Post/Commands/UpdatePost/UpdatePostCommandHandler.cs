using AutoMapper;
using MediatR;
using Post.Application.Contracts;
using Posts.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Application.Features.Post.Commands.UpdatePost;
public class UpdatePostCommandHandler : IRequestHandler<UpdatePostCommand>
{
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;

    public UpdatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
    {
        _postRepository = postRepository;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
    {
        Posts.Domain.Post post = _mapper.Map<Posts.Domain.Post>(request);

        await _postRepository.UpdateAsync(post);
        return Unit.Value;

    }
}
