using CapFootTournament.BlazorUI.Models;

namespace CapFootTournament.BlazorUI.Contracts
{
	public interface ICapgeminiContract
	{
		public List<Capgemini> ListCapgemini { get; set; }
		public Task GetAllCapgeminisAsync();
	}
}
