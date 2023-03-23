using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadeed.Data.Entities;

public class Dashboard
{
    public long SubjectId { get; set; }
    public Subject Subject { get; set; }    
    public long UserId { get; set; }
    //public User User { get; set; }
    public long OrganizationId { get; set; }
    //public Organization Organization { get; set; } 
    public long GradeId { get; set; }
    //public Grade Grade { get; set; }
}
