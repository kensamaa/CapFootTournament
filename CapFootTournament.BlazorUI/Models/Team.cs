namespace CapFootTournament.BlazorUI.Models
{
	public class Team
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int Classement { get; set; }
		public int Points { get; set; }
		public string City { get; set; } = string.Empty;
	}
}
