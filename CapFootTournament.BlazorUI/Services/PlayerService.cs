using CapFootTournament.BlazorUI.Contracts;
using CapFootTournament.BlazorUI.Models;
using System.Net.Http.Json;

namespace CapFootTournament.BlazorUI.Services
{
	public class PlayerService : IPlayerContract
	{
		private readonly HttpClient httpClient;

		public List<Player> ListPlayer { get; set ; }= new List<Player>();
		public PlayerDetail PlayerDetails { get; set; }= new PlayerDetail();

		public PlayerService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}
		public async Task GetAllPlayersAsync()
		{
			var res = await httpClient.GetFromJsonAsync<List<Player>>($"{Constant.API}/Player");
			if (res != null)
				ListPlayer = res;
		}

		public async Task GetPlayerByIdAsync(Guid id)
		{
			var res = await httpClient.GetFromJsonAsync<PlayerDetail>($"{Constant.API}/Player/{id}");
			if (res != null)
				PlayerDetails = res;
		}
	}
}
