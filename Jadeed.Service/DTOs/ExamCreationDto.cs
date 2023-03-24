using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadeed.Service.DTOs
{
    public class ExamCreationDto
    {
        public long SubjectId { get; set; }
        public long StudentId { get; set; }
        public long TypeId { get; set; }
        public long PassMark { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime DeadLine { get; set; }
    }
}
