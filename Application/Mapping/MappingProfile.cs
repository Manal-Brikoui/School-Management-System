using Application.DTOs;
using AutoMapper;
using School.Domain.Entities;

namespace School.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
           
            CreateMap<Student, StudentDto>().ReverseMap();

            
            CreateMap<Teacher, TeacherDto>().ReverseMap();

            
            CreateMap<Subject, SubjectDto>().ReverseMap();

            CreateMap<Grade, GradeDto>().ReverseMap();
        }
    }
}
