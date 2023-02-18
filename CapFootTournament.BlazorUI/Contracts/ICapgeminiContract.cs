using CapFootTournament.BlazorUI.Models;

namespace CapFootTournament.BlazorUI.Contracts
{
	public interface ICapgeminiContract
	{
		public List<Capgemini> ListCapgemini { get; set; }
		public Capgemini CapgeminiDetails { get; set; }
		public Task GetAllCapgeminisAsync();
		public Task GetCapgeminiByIdAsync(Guid id);
	}
}
