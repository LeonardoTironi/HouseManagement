using AutoMapper;
using HouseManagement.Application.DTOs;
using HouseManagement.Domain.Entity;

namespace HouseManagement.Application.Helpers
{
    public class HouseManagementProfiler : Profile
    {
        public HouseManagementProfiler()
        {
            CreateMap<Person, PersonAddDTO>().ReverseMap();
            CreateMap<Person, PersonResponseDTO>().ReverseMap();
            CreateMap<Person, PersonUpdateDTO>().ReverseMap();

        }

    }
}
