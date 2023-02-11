using Domain.Common;

namespace Domain.Entites;

public class Capgemini : Entity
{
    public Capgemini() { 
        this.Tournaments= new List<Tournament>();
    }
    public string Name { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public int NumberOfTeams { get; set; } = 0;
    public virtual ICollection<Tournament> Tournaments { get; set; } 
    public DateTime DateCreation { get; set; }
}

