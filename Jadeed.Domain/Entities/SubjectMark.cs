using Jadeed.Domain.Entities;
using Jadeed.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadeed.Data.Entities;

public class SubjectMark
{
    public long StudentDetailId { get; set; }
    public StudentDetail StudentDetails { get; set; }
    public SubjectType SubjectType { get; set; } 
    public int Mark { get; set; }
}
