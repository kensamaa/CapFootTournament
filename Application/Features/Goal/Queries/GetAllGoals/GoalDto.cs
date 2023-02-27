using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Goal.Queries.GetAllGoals
{
	public class GoalDto
	{
		public Guid PlayerId { get; set; }
		public Guid MatchId { get; set; }
		public DateTime GoalDate { get; set; }
		public int Goalminute { get; set; }
	}
}
