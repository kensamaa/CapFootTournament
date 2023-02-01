using Application.Contracts.Repository;
using Domain.Entites;
using Infrastructure.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TournamentRepository : GenericRepository<Tournament>, ITournamentRepository
    {
        public TournamentRepository(CapFootDatabaseContext context) :base(context) { 
        
        }
        public Task<bool> IsTournamentUnique(string name)
        {
            throw new NotImplementedException();
        }
    }
}
