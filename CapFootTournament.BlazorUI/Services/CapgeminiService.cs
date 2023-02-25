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
		public Capgemini CapgeminiDetails { get; set; } = new Capgemini();
		public CapgeminiService(HttpClient httpClient)
		{
			_http = httpClient;
		}
		public async Task GetAllCapgeminisAsync()
		{
			var res = await _http.GetFromJsonAsync<List<Capgemini>>($"{Constant.API}/Capgemini");
			if (res != null)
				ListCapgemini = res;
		}

		public async Task GetCapgeminiByIdAsync(String id)
		{
			var res = await _http.GetFromJsonAsync<Capgemini>($"{Constant.API}/Capgemini/{id}");
			if (res != null)
				CapgeminiDetails = res;
		}
	}
}
