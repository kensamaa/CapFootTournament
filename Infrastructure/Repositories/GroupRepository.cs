using Application.Contracts.Repository;
using Domain.Entites;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class GroupRepository : GenericRepository<Groupe>,IGroupRepository
    {
        public GroupRepository(CapFootDatabaseContext context) : base(context) { }

        public async Task<bool> IsGroupUnique(string name)
        {
            return await _context.Groups.AnyAsync(q => q.Name == name);
        }

    }
}
