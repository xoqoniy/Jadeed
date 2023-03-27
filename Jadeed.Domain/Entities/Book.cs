using Jadeed.Domain.Commons;

namespace Jadeed.Domain.Entities;

public class Book : Auditable
{
    public string Title { get; set; }
    public string Description { get; set; }
    public long Count { get; set; }
    public long LibraryId { get; set; }
    public Library Library { get; set; }
}
