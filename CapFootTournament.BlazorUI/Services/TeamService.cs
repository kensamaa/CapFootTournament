using CapFootTournament.BlazorUI.Contracts;
using CapFootTournament.BlazorUI.Models;
using System.Net.Http.Json;

namespace CapFootTournament.BlazorUI.Services
{
	public class TeamService : ITeamContract
	{
		private readonly HttpClient httpClient;

		public List<Team> ListTeam { get ; set ; }= new List<Team>();
		public TeamDetailM TeamDetails { get; set; } = new TeamDetailM();
		public TeamService(HttpClient httpClient)
		{
			this.httpClient = httpClient;
		}
		public async Task GetAllTeamsAsync()
		{
			var res = await httpClient.GetFromJsonAsync<List<Team>>($"{Constant.API}/Team");
			if (res != null)
				ListTeam = res;
		}

		public async Task GetTeamByIdAsync(string id)
		{
			var res = await httpClient.GetFromJsonAsync<TeamDetailM>($"{Constant.API}/Team/{id}");
			if (res != null)
				TeamDetails = res;
		}
	}
}
