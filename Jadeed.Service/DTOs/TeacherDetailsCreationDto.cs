using Jadeed.Domain.Enums;

namespace Jadeed.Service.DTOs
{
    public class TeacherDetailsCreationDto
    {
        public long Id { get; set; }
        public long GradeId { get; set; }
        public int Experience { get; set; }
        public decimal Salary { get; set; }
        public SubjectType Specialty { get; set; }
        public TeacherLevel Level { get; set; }
        public string Description { get; set; }
    }
}
