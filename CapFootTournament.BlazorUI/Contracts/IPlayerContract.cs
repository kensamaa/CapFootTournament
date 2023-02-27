using CapFootTournament.BlazorUI.Models;

namespace CapFootTournament.BlazorUI.Contracts
{
	public interface IPlayerContract
	{
		public List<Player> ListPlayer { get; set; }
		public PlayerDetail PlayerDetails { get; set; }
		public Task GetAllPlayersAsync();
		public Task GetPlayerByIdAsync(Guid id);
	}
}
