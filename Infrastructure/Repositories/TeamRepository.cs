using Application.Contracts.Repository;
using Application.Features.Player.Queries.GetPlayers;
using Domain.Entites;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
	public class TeamRepository : GenericRepository<Team>, ITeamRepository
	{
		public TeamRepository(CapFootDatabaseContext context) : base(context)
		{
		}

		public async Task<List<Player>> getListPlayers(Guid TeamId)
		{
			return await _context.Players.Where(g => g.TeamId == TeamId).ToListAsync();
		}
	}
}
