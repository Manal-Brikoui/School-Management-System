using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Application.Interfaces
{
    public interface ITeacherRepository
    {
        Task<List<Teacher>> GetAllAsync();
        Task<Teacher?> GetByIdAsync(Guid id);
        Task AddAsync(Teacher teacher);
        Task<bool> DeleteAsync(Guid id);
    }
}
