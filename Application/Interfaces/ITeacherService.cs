
using Application.DTOs;

namespace School.Application.Interfaces
{
    public interface ITeacherService
    {
        Task<List<TeacherDto>> GetAllAsync();
        Task<TeacherDto?> GetByIdAsync(Guid id);
        Task<TeacherDto> CreateAsync(TeacherDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
