using Application.Contracts.Repository;
using Domain.Entites;
using Infrastructure.DatabaseContext;

namespace Infrastructure.Repositories
{
	public class TeamRepository : GenericRepository<Team>, ITeamRepository
	{
		public TeamRepository(CapFootDatabaseContext context) : base(context)
		{
		}
	}
}
