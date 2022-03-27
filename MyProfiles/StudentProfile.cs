using AutoMapper;
using AutoMapperStudy.Model;
using AutoMapperStudy.Model.Dto;

namespace AutoMapperStudy.MyProfiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student,StudentDto>().ForMember(des=>des.Name,option=>option.MapFrom(map=>map.Name));   
        }
    }
}