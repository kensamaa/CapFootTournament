using Application.Features.Goal.Queries.GetAllGoals;
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Player.Queries.GetPlayerDetails
{
	public class PlayerDetailDto
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string FamilyName { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public bool IsCaptain { get; set; }
		public List<Card> ListCards { get; set; }=new List<Card>();
		public List<GoalDto> ListGoals { get; set; }=new List<GoalDto> { new GoalDto() };
	}
}
