using Application.Features.Player.Queries.GetPlayers;
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repository
{
	public  interface ITeamRepository: IGenericRepository<Team>
	{
		Task<List<Player>> getListPlayers(Guid TeamId);
	}
}
