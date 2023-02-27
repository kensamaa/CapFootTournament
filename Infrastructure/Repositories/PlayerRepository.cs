using Application.Contracts.Repository;
using Domain.Entites;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class PlayerRepository : GenericRepository<Player>, IPlayerRepository
{
	public PlayerRepository(CapFootDatabaseContext context) : base(context)
	{
	}
	public async Task<List<Goal>> getListGoals(Guid id)
	{
		return await _context.Goals.Where(g => g.PlayerId == id).ToListAsync();
	}
}
