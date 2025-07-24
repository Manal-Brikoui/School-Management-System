using System;

namespace School.Domain.Entities
{
    public class Grade
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }
        public decimal Score { get; set; }

        // Propriétés de navigation vers Student et Subject
        public Student? Student { get; set; }
        public Subject? Subject { get; set; }
    }
}
