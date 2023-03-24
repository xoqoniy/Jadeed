using Jadeed.Domain.Commons;
using Jadeed.Domain.Enums;

namespace Jadeed.Domain.Entities;

public class TeacherDetail:Auditable
{
    public long GradeId { get; set; }
    public Grade Grade { get; set; }
    public int Experience { get; set; }
    public decimal Salary { get; set; }
    public SubjectType Type { get; set; }
    public TeacherLevel Level { get; set; }
    public string Description { get; set; }
}
