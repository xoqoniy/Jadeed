using Jadeed.Data.Entities;

namespace Jadeed.Service.DTOs;

public class SubjectCreationDto
{
    public string Name { get; set; }
    public DateTime StartedTime { get; set; }
    public DateTime Duration { get; set; }
    public ICollection<Dashboard> Dashboards { get; set; }
}
