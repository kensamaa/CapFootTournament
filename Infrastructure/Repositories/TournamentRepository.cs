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
    public class TournamentRepository : GenericRepository<Tournament>, ITournamentRepository
    {
        public TournamentRepository(CapFootDatabaseContext context) :base(context) {
        }

        public  Task assignCapgeminiListsToTournament(List<Capgemini> pCapgeminiList,Tournament pTournament)
        {
            var lCapgeminiList = _context.Tournaments.Find(pTournament);
            if (lCapgeminiList == null) return Task.CompletedTask;

            foreach(Capgemini cap in pCapgeminiList)
            {
                //lCapgeminiList.Capgeminis.Add(cap);
            }
            this._context.SaveChanges();
            return  Task.CompletedTask;

        }

        public Task<List<Groupe>> getListGroupes(Guid tournamentId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> isTournamentInscriptionsFinished(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> IsTournamentUnique(string name)
        {
            return await _context.Tournaments.AnyAsync(q => q.Name == name);
        }

        public Task<List<Groupe>> runDrawStage(List<Team> teams)
        {
            throw new NotImplementedException();
        }
    }
}
