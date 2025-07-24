using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class GradeDto
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }
        public decimal Score { get; set; }
    }
    public class CreateGradeDto
    {
        public Guid StudentId { get; set; }
        public Guid SubjectId { get; set; }
        public decimal Score { get; set; }
    }
}
