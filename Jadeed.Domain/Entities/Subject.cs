using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadeed.Data.Entities;

public class Subject
{
    public string Name { get; set; }
    public DateTime StartedTime { get; set; }
    public DateTime Duration { get; set; }
    public ICollection<Dashboard> Dashboards { get; set;}
}
