using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Application.Interfaces
{
    public interface IGradeService
    {
        Task<List<GradeDto>> GetAllAsync();
        Task<GradeDto?> GetByIdAsync(Guid id);
        Task<GradeDto> CreateAsync(GradeDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
