using Application.DTOs;
using AutoMapper;
using School.Application.Interfaces;
using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Application.Services
{
    public class GradeService : IGradeService
    {
        private readonly IGradeRepository _repository;
        private readonly IMapper _mapper;

        public GradeService(IGradeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GradeDto>> GetAllAsync()
        {
            var grades = await _repository.GetAllAsync();
            return _mapper.Map<List<GradeDto>>(grades);
        }

        public async Task<GradeDto?> GetByIdAsync(Guid id)
        {
            var grade = await _repository.GetByIdAsync(id);
            return grade == null ? null : _mapper.Map<GradeDto>(grade);
        }

        public async Task<GradeDto> CreateAsync(GradeDto dto)
        {
            var grade = _mapper.Map<Grade>(dto);
            await _repository.AddAsync(grade);
            return _mapper.Map<GradeDto>(grade);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
