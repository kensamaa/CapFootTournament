using Application.Contracts.Repository;
using Domain.Entites;
using Infrastructure.DatabaseContext;

namespace Infrastructure.Repositories;

public class GoalRepository : GenericRepository<Goal>, IGoalRepository
{
	public GoalRepository(CapFootDatabaseContext context):base(context) { }

}
