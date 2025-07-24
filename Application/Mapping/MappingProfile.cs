using Application.DTOs;
using AutoMapper;
using School.Domain.Entities;

namespace School.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Mapping pour Student <-> StudentDto
            CreateMap<Student, StudentDto>().ReverseMap();

            // Mapping pour Teacher <-> TeacherDto
            CreateMap<Teacher, TeacherDto>().ReverseMap();

            // Mapping pour Subject <-> SubjectDto
            CreateMap<Subject, SubjectDto>().ReverseMap();

            // Mapping pour Grade <-> GradeDto
            CreateMap<Grade, GradeDto>().ReverseMap();
        }
    }
}
