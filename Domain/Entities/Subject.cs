using System;

namespace School.Domain.Entities
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid TeacherId { get; set; }

        // Propriété de navigation vers l'entité Teacher
        public Teacher? Teacher { get; set; }
    }
}
