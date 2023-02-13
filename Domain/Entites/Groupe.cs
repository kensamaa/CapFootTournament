using Domain.Common;

namespace Domain.Entites;

public class Groupe : Entity
{
	public Groupe()
	{
		ListeTeams = new List<Team>();
	}
	public Guid TournamentId { get; set; }
	public string Name { get; set; } = string.Empty;
	public virtual List<Team> ListeTeams { get; set; }
}

