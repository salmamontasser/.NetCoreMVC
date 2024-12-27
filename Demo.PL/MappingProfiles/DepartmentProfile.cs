using AutoMapper;
using Demo.PL.ViewModels;
using DemoDAL.Models;

namespace Demo.PL.MappingProfiles
{
    public class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            CreateMap<DepartmentViewModel, Department>().ReverseMap();
        }
    }
}
