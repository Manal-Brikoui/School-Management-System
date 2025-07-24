using Application.DTOs;
using AutoMapper;
using School.Application.Interfaces;
using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Application.Services
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _repository;
        private readonly IMapper _mapper;

        public SubjectService(ISubjectRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<SubjectDto>> GetAllAsync()
        {
            var subjects = await _repository.GetAllAsync();
            return _mapper.Map<List<SubjectDto>>(subjects);
        }

        public async Task<SubjectDto?> GetByIdAsync(Guid id)
        {
            var subject = await _repository.GetByIdAsync(id);
            return subject == null ? null : _mapper.Map<SubjectDto>(subject);
        }

        public async Task<SubjectDto> CreateAsync(SubjectDto dto)
        {
            var subject = _mapper.Map<Subject>(dto);
            await _repository.AddAsync(subject);
            return _mapper.Map<SubjectDto>(subject);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }
    }
}
