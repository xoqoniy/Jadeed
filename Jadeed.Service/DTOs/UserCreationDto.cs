using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadeed.Service.DTOs
{
    public class UserCreationDto
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public UserRole Role { get; set; }
    }
}
