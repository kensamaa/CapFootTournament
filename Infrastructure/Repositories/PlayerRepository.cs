using Application.Contracts.Repository;
using Domain.Entites;
using Infrastructure.DatabaseContext;

namespace Infrastructure.Repositories
{
	public class PlayerRepository : GenericRepository<Player>, IPlayerRepository
	{
		public PlayerRepository(CapFootDatabaseContext context) : base(context)
		{
		}
	}
}
