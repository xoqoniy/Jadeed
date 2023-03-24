using Jadeed.Domain.Enums;
namespace Jadeed.Service.DTOs
{
    public class UserCreationDto
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public UserRole Role { get; set; }
        public long AddressId { get; set; }
        public int Phone { get; set; }
        public GenderType Gender { get; set; }
        public long StudentDetailsId { get; set; }
        public long TeacherDetailsId { get; set; }
    }
}