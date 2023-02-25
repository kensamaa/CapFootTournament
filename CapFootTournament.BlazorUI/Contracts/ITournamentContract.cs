using CapFootTournament.BlazorUI.Models;

namespace CapFootTournament.BlazorUI.Contracts
{
	public interface ITournamentContract
	{
		public List<Tournament> ListTournament { get; set; }
		public Tournament TournamentDetails { get; set; }
		public Task GetAllTournamentsAsync();
		public Task GetTournamentByIdAsync(Guid id);
	}
}
