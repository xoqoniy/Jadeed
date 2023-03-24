using Jadeed.Domain.Commons;
using Jadeed.Domain.Enums;

namespace Jadeed.Domain.Entities;

public class User:Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfTime { get; set; }
    public UserRole Role { get; set; }
    public long AddressId { get; set; }
    public Address Address { get; set; }
    public string Phone { get; set; }
    public long? StudentDetailId { get; set; }
    public StudentDetail StudentDetail { get; set; }
    public long? TeacherDetailId { get; set; }
    public TeacherDetail TeacherDetail { get; set; }
}
