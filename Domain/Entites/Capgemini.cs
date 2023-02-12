using Domain.Common;

namespace Domain.Entites;

public class Capgemini : Entity
{
    public Capgemini() { 
        this.capgeminiTournament = new List<CapgeminiTournament>();
    }
    public string Name { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public int NumberOfTeams { get; set; } = 0;
    public virtual IList<CapgeminiTournament> capgeminiTournament { get; set; }
    public DateTime DateCreation { get; set; }
}

