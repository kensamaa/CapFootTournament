using System;
namespace Application.Contracts.Repository
{
	public interface IGenericRepository<T> where T : class
	{
		Task<IReadOnlyList<T>> GetAsync();
        Task<T> GetByIdAsync(Guid pId);
        Task CreateAsync(T pEntity);
        Task UpdateAsync(T pEntity);
        Task DeleteAsync(T pEntity);

    }
}

