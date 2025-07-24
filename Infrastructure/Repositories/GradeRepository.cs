using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;
using School.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using School.Application.Interfaces;

namespace School.Infrastructure.Repositories
{
  

    public class GradeRepository : IGradeRepository
    {
        private readonly AppDbContext _context;
        public GradeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Grade>> GetAllAsync()
        {
            return await _context.Grades.ToListAsync();
        }

        public async Task<Grade?> GetByIdAsync(Guid id)
        {
            return await _context.Grades.FindAsync(id);
        }

        public async Task AddAsync(Grade grade)
        {
            await _context.Grades.AddAsync(grade);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var grade = await _context.Grades.FindAsync(id);
            if (grade == null) return false;

            _context.Grades.Remove(grade);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
