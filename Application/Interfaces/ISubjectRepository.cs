using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Application.Interfaces
{
    public interface ISubjectRepository
    {
        Task<List<Subject>> GetAllAsync();
        Task<Subject?> GetByIdAsync(Guid id);
        Task AddAsync(Subject subject);
        Task<bool> DeleteAsync(Guid id);
    }
}
