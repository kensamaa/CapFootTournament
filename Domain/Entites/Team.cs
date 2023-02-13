using Domain.Common;

namespace Domain.Entites;

public class Team : Entity
{
	public Team()
	{
		Listplayers = new List<Player>();
	}
	public string Name { get; set; } = string.Empty;
	public Guid GroupeId { get; set; }
	public int Classement { get; set; }
	public int Points { get; set; }
	public string City { get; set; } = string.Empty;
	public Guid CapgeminiId { get; set; }
	public virtual List<Player> Listplayers { get; set; }

}

