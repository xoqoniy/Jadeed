using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadeed.Service.DTOs
{
    public class GradeCreationDto
    {
        public int Level { get; set; }
        public string LevelKey { get; set; }
        public long TeacherId { get; set; }
        public long StudentsId { get; set; }
        public long SubjectId { get; set; }
    }
}
