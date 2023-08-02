using AutoMapper;
using SocialNetwork.Domain;
using SocialNetwork.Domain.Dtos.User;

namespace SocialNetwork.Application.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, UserListDto>().ReverseMap();
    }
}
