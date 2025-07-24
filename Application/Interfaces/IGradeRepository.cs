using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Application.Interfaces
{
    public interface IGradeRepository
    {
        Task<List<Grade>> GetAllAsync();
        Task<Grade?> GetByIdAsync(Guid id);
        Task AddAsync(Grade grade);
        Task<bool> DeleteAsync(Guid id);
    }
}
