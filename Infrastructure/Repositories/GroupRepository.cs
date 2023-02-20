using Application.Contracts.Repository;
using Domain.Entites;
using Infrastructure.DatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class GroupRepository : GenericRepository<Groupe>,IGroupRepository
    {
        public GroupRepository(CapFootDatabaseContext context) : base(context) { }

        public async Task<bool> IsGroupUnique(string name)
        {
            return await _context.Groups.AnyAsync(q => q.Name == name);
        }
        public async Task<List<Team>> getListTeam(Guid groupId)
        {
            return await _context.Teams.Where(g=>g.GroupeId== groupId).ToListAsync();
        }

    }
}
