using Domain.Common;

namespace Domain.Entites;

public class Player : Entity
{
	public Player()
	{
		ListCards = new List<Card>();
		ListGoals = new List<Goal>();
	}
	public string Name { get; set; } = string.Empty;
	public string FamilyName { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public Guid TeamId { get; set; }
	public bool IsCaptain { get; set; } =false;
	public List<Card> ListCards { get; set; }
	public List<Goal> ListGoals { get; set; }
}

