using Jadeed.Domain.Commons;

namespace Jadeed.Domain.Entities;

public class UserBook : Auditable
{
    public long BookId { get; set; }
    public Book Book { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public DateTime GettingTime { get; set; }
    public DateTime Deadline { get; set; }
    public decimal Penalty { get; set; }
    public bool IsPenalty { get; set; }
}
