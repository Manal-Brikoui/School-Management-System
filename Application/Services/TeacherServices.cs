using Application.DTOs;
using AutoMapper;
using School.Application.Interfaces;
using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Application.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _repository;
        private readonly IMapper _mapper;

        public TeacherService(ITeacherRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<TeacherDto>> GetAllAsync()
        {
            var teachers = await _repository.GetAllAsync();
            return _mapper.Map<List<TeacherDto>>(teachers);
        }

        public async Task<TeacherDto?> GetByIdAsync(Guid id)
        {
            var teacher = await _repository.GetByIdAsync(id);
            return teacher == null ? null : _mapper.Map<TeacherDto>(teacher);
        }

        public async Task<TeacherDto> CreateAsync(TeacherDto dto)
        {
            var teacher = _mapper.Map<Teacher>(dto);
            await _repository.AddAsync(teacher);
            return _mapper.Map<TeacherDto>(teacher);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
