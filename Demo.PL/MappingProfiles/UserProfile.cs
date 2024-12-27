using AutoMapper;
using Demo.PL.ViewModels;
using DemoDAL.Models;

namespace Demo.PL.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser,UsersViewModel>().ReverseMap();
        }
    }
}
