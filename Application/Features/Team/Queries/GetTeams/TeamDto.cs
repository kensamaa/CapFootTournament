namespace Application.Features.Team.Queries.GetTeams
{
	public class TeamDto
	{
		public string Name { get; set; } = string.Empty;
		public Guid Id { get; set; }
		public int Classement { get; set; }
		public int Points { get; set; }
		public string City { get; set; } = string.Empty;
	}
}
