using Jadeed.Domain.Commons;

namespace Jadeed.Domain.Entities;

public class StudentDetail:Auditable
{
    public long? GradeId { get; set; }
    public Grade Grade { get; set; }
    public long ParentId { get; set; }

}
