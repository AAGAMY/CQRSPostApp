using AutoMapper;
using MediatR;
using Post.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Post.Domain;

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
        
        

       throw new NotImplementedException();
    }

    //public async Task<Guid> Handle(CreatePostCommand request, CancellationToken cancellationToken)
    //{
    //    Post post = _mapper.Map<Post.Domain.Post>(request);

    //    CreateCommandValidator validator = new CreateCommandValidator();
    //    var result = await validator.ValidateAsync(request);
    //}
}
