using Jadeed.Domain.Commons;

namespace Jadeed.Domain.Entities;

public class Library : Auditable
{
    public ICollection<Book> Books { get; set; }
    public string WorkingDay { get; set; }
    public string WorkingHour { get; set; }
}
