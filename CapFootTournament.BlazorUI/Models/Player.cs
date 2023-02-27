namespace CapFootTournament.BlazorUI.Models
{
	public class Player
	{
		public string Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public string FamilyName { get; set; } = string.Empty;
		public string Email { get; set; } = string.Empty;
		public bool IsCaptain { get; set; } = false;
	}
}
