using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Application.Interfaces
{
    public interface ISubjectService
    {
        Task<List<SubjectDto>> GetAllAsync();
        Task<SubjectDto?> GetByIdAsync(Guid id);
        Task<SubjectDto> CreateAsync(SubjectDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
