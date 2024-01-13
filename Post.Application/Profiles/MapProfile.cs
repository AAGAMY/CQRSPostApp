using AutoMapper;
using Post.Application.Features.Post.Queries.GetPostDetails;
using Post.Application.Features.Post.Queries.GetPostList;


namespace Post.Application.Profiles;
public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<Post.Domain.Post, GetPostsListViewModel>().ReverseMap();
        CreateMap<Post.Domain.Post, GetPostDetailViewModel>().ReverseMap();
    }
}
