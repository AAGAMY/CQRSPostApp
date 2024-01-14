using AutoMapper;
using MediatR;
using Post.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Posts.Domain;

namespace Post.Application.Features.Post.Commands.CreatePost;
//Create New from CreatePostCommand and generate new Guid
public class CreatePostCommandHandler : IRequestHandler<CreatePostCommand, Guid>
{
    private readonly IPostRepository _postRepository;
    private readonly IMapper _mapper;

    public CreatePostCommandHandler(IPostRepository postRepository, IMapper mapper)
    {
        _postRepository = postRepository;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreatePostCommand request, CancellationToken cancellationToken)
    {

        Posts.Domain.Post post = _mapper.Map<Posts.Domain.Post>(request);
        CreateCommandValidator validator = new CreateCommandValidator();
        var result = await validator.ValidateAsync(request);

        if (result.Errors.Any())
            throw new Exception("Post is not valid");
        post = await _postRepository.AddAsync(post);
        return post.Id;

    }

}
