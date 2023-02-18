using Application.Contracts.Repository;
using Application.Features.Player.Queries.GetPlayers;
using Domain.Entites;
using Infrastructure.DatabaseContext;

namespace Infrastructure.Repositories
{
	public class TeamRepository : GenericRepository<Team>, ITeamRepository
	{
		public TeamRepository(CapFootDatabaseContext context) : base(context)
		{
		}

		public async Task<List<Player>> getListPlayers(Guid TeamId)
		{
			return await _context.Pla  //.Groups.Where(g => g.TournamentId == tournamentId).ToListAsync();
		}
	}
}
