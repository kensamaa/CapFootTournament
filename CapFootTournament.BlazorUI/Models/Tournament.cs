namespace CapFootTournament.BlazorUI.Models
{
	public class Tournament
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public DateTime DateCreation { get; set; }
		public Boolean isStarted { get; set; } = false;
		public Boolean isSignUpCompleted { get; set; }
		public Boolean isFinished { get; set; }
		public String CountryOrganisation { get; set; } = string.Empty;
	}
}
