using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Team.Queries.GetTeams
{
	public  class TeamDetailDto
	{
		public string Name { get; set; } = string.Empty;
		public Guid GroupeId { get; set; }
		public int Classement { get; set; }
		public int Points { get; set; }
		public string City { get; set; } = string.Empty;
		public Guid CapgeminiId { get; set; }
		public virtual List<Player> Listplayers { get; set; } = new List<Player> { };
	}
}
