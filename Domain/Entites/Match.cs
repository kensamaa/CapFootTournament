using System;
namespace Domain.Entites
{
	public class Match
	{
		public Guid Id { get; set; }
		public Guid TeamAId { get; set; }
		public Guid TeamBId { get; set; }
		public int NumberGoalsTeamA { get; set; }
		public int NumberGoasTeamB { get; set; }
		public DateTime MatchStart { get; set; }
		public DateTime MathEnd { get; set; }
		public string RefereeName { get; set; }
        public Match()
		{
		}
	}
}

