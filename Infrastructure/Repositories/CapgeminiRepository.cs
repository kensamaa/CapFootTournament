using System;
using Application.Contracts.Repository;
using Domain.Entites;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
	public class CapgeminiRepository : GenericRepository<Capgemini>,ICapgeminiRepository
    {
		public CapgeminiRepository(CapFootDatabaseContext context):base(context)
		{
		}
        public async Task<bool> IsCapgeminiUnique(string name)
		{
			return await _context.Capgeminis.AnyAsync(q => q.Name == name);
		}
    }
}

