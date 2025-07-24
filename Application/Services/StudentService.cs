using Application.DTOs;
using AutoMapper;
using School.Application.Interfaces;
using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace School.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _repository;
        private readonly IMapper _mapper;

        public StudentService(IStudentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<StudentDto>> GetAllAsync()
        {
            var students = await _repository.GetAllAsync();
            return _mapper.Map<List<StudentDto>>(students);
        }

        public async Task<StudentDto?> GetByIdAsync(Guid id)
        {
            var student = await _repository.GetByIdAsync(id);
            return student == null ? null : _mapper.Map<StudentDto>(student);
        }

        public async Task<StudentDto> CreateAsync(StudentDto dto)
        {
            var student = _mapper.Map<Student>(dto);
            await _repository.AddAsync(student);
            return _mapper.Map<StudentDto>(student);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
