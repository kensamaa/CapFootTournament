using Domain.Entites;

namespace Application.Contracts.Repository;

public interface IPlayerRepository : IGenericRepository<Player>
{
	Task<List<Goal>> getListGoals(Guid id);
}
