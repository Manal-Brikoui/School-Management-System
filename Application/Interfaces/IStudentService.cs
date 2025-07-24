using Application.DTOs;  // PAS Application.DTOs ou autre
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace School.Application.Interfaces
{
    public interface IStudentService
    {
        Task<List<StudentDto>> GetAllAsync();
        Task<StudentDto?> GetByIdAsync(Guid id);
        Task<StudentDto> CreateAsync(StudentDto dto);
        Task<bool> DeleteAsync(Guid id);
    }
}
