using System;
using Application.Contracts.Repository;
using Domain.Common;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : Entity
	{
		protected readonly CapFootDatabaseContext _context;

		public GenericRepository(CapFootDatabaseContext context)
		{
			this._context = context;
		}

		public async Task CreateAsync(T pEntity)
		{
			await _context.AddAsync(pEntity);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(T pEntity)
		{
			_context.Remove(pEntity);
			await _context.SaveChangesAsync();

		}

		public async Task<IReadOnlyList<T>> GetAsync()
		{
			return await _context.Set<T>().AsNoTracking().ToListAsync();
		}

		public async Task<T> GetByIdAsync(Guid pId)
		{
			return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(q => q.Id == pId);
		}

		public async Task UpdateAsync(T pEntity)
		{
			_context.Entry(pEntity).State = EntityState.Modified;
			await _context.SaveChangesAsync();
		}
	}
}

