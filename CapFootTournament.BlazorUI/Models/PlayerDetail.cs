namespace CapFootTournament.BlazorUI.Models
{
	public class PlayerDetail
	{
		public string Name { get; set; } = string.Empty;
		public string FamilyName { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public Guid TeamId { get; set; }
		public bool IsCaptain { get; set; } = false;
		public List<Card> ListCards { get; set; }
		public List<Goal> ListGoals { get; set; }
	}
}
