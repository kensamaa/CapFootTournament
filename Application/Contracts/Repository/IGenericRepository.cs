using System;
namespace Application.Contracts.Repository
{
	public interface IGenericRepository<T> where T : class
	{
		Task<List<T>> GetAsync();
        Task<T> GetByIdAsync(Guid pId);
        Task<T> CreateAsync(T pEntity);
        Task<T> UpdateAsync(T pEntity);
        Task<T> DeleteAsync(T pEntity);

    }
}

