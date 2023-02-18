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
    public class CapgeminiTournamentRepository : GenericRepository<Tournament>, ICapgeminiTournament
    {
        public CapgeminiTournamentRepository(CapFootDatabaseContext context) : base(context) { }

        public Task<List<Capgemini>> GetAllCapgeminisInTournaments(Guid pIdTournament)
        {
            return _context.CapgeminiTournaments.Where(ct => ct.tournamentId.Equals(pIdTournament))
                .Select(ct => ct.capgemini).ToListAsync();
        }

        public Task<List<Tournament>> GetAllTournamentsByCapgeminiId(Guid pIdCapgemini)
        {
            throw new NotImplementedException();
        }
    }
}
