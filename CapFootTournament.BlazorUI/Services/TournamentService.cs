using CapFootTournament.BlazorUI.Contracts;
using CapFootTournament.BlazorUI.Models;
using CapFootTournament.BlazorUI.Pages;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace CapFootTournament.BlazorUI.Services
{
	public class TournamentService : ITournamentContract
	{
		private readonly HttpClient httpClient;

		public List<Tournament> ListTournament { get; set; } = new List<Tournament> { };
		public Tournament TournamentDetails { get; set; } = new Tournament();

		public TournamentService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}
		public async Task GetAllTournamentsAsync()
		{
			var res = await httpClient.GetFromJsonAsync<List<Tournament>>($"{Constant.API}/Tournament");
			if (res != null)
				ListTournament = res;
		}

		public async Task GetTournamentByIdAsync(Guid id)
		{
			var res = await httpClient.GetFromJsonAsync<Tournament>($"{Constant.API}/Tournament/{id}");
			if (res != null)
				TournamentDetails = res;
		}
	}
}
