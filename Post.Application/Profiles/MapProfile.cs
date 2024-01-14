using AutoMapper;
using Post.Application.Features.Post.Commands.CreatePost;
using Post.Application.Features.Post.Commands.UpdatePost;
using Post.Application.Features.Post.Queries.GetPostDetails;
using Post.Application.Features.Post.Queries.GetPostList;

namespace Post.Application.Profiles;
public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<Posts.Domain.Post, GetPostsListViewModel>().ReverseMap();
        CreateMap<Posts.Domain.Post, GetPostDetailViewModel>().ReverseMap();
        CreateMap<Posts.Domain.Post, CreatePostCommand>().ReverseMap();
        CreateMap<Posts.Domain.Post, UpdatePostCommand>().ReverseMap();
    }
}
