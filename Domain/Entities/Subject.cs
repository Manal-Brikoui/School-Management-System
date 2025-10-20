using System;

namespace School.Domain.Entities
{
    public class Subject
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid TeacherId { get; set; }

        public Teacher? Teacher { get; set; }
    }
}
