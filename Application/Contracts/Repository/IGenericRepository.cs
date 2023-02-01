using System;
using Domain.Common;

namespace Application.Contracts.Repository
{
	public interface IGenericRepository<T> where T : Entity
    {
		Task<IReadOnlyList<T>> GetAsync();
        Task<T> GetByIdAsync(Guid pId);
        Task CreateAsync(T pEntity);
        Task UpdateAsync(T pEntity);
        Task DeleteAsync(T pEntity);

    }
}

