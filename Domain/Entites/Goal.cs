using Domain.Common;

namespace Domain.Entites;

public class Goal:Entity
{
    public Guid PlayerId { get; set; }
    public Guid MatchId { get; set; }
    public DateTime GoalDate { get; set; }
    public int Goalminute { get; set; }
}

