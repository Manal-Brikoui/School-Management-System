using Microsoft.EntityFrameworkCore;
using School.Domain.Entities;
using School.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using School.Application.Interfaces;

namespace School.Infrastructure.Repositories
{
   
    

    public class SubjectRepository : ISubjectRepository
    {
        private readonly AppDbContext _context;
        public SubjectRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Subject>> GetAllAsync()
        {
            return await _context.Subjects.ToListAsync();
        }

        public async Task<Subject?> GetByIdAsync(Guid id)
        {
            return await _context.Subjects.FindAsync(id);
        }

        public async Task AddAsync(Subject subject)
        {
            await _context.Subjects.AddAsync(subject);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var subject = await _context.Subjects.FindAsync(id);
            if (subject == null) return false;

            _context.Subjects.Remove(subject);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
