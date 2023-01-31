using System;
namespace Domain.Entites
{
	public class Goal
	{
		public Guid Id { get; set; }
        public Guid PlayerId { get; set; }
        public Guid MatchId { get; set; }
        public DateTime GoalDate { get; set; }
        public int Goalminute { get; set; }
        public Goal()
		{
            Id = Guid.NewGuid();
        }
	}
}

