using CapFootTournament.BlazorUI.Contracts;
using CapFootTournament.BlazorUI.Models;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace CapFootTournament.BlazorUI.Services
{
	public class CapgeminiService : ICapgeminiContract
	{
		private readonly HttpClient _http;
		public List<Capgemini> ListCapgemini { get; set; } = new List<Capgemini>();
		public CapgeminiService(HttpClient httpClient)
		{
			_http = httpClient;
		}
		public async Task GetAllCapgeminisAsync()
		{
			var res = await _http.GetFromJsonAsync<List<Capgemini>>("https://localhost:7147/api/Capgemini");
			if (res != null)
				ListCapgemini = res;

		}
	}
}
