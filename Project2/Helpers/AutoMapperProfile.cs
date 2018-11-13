using AutoMapper;
using Project2.Dtos;
using Project2.Entities;

namespace Project2.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}