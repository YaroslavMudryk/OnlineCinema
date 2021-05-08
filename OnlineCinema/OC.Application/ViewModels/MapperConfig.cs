using AutoMapper;
using OC.Application.ViewModels.Users;
using OC.Domain.Models;
namespace OC.Application.ViewModels
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<User, UserViewModel>().ReverseMap();
        }
    }
}