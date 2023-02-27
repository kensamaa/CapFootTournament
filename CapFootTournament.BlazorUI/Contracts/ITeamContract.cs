using CapFootTournament.BlazorUI.Models;

namespace CapFootTournament.BlazorUI.Contracts
{
	public interface ITeamContract
	{
		public List<Team> ListTeam { get; set; }
		public TeamDetail TeamDetails { get; set; }
		public Task GetAllTeamsAsync();
		public Task GetTeamByIdAsync(Guid id);
	}
}
