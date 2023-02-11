using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repository
{
    public interface ITournamentRepository : IGenericRepository<Tournament>
    {
        Task<bool> IsTournamentUnique(string name);
        Task<bool> isTournamentInscriptionsFinished(Guid id);
        Task<List<Groupe>> runDrawStage(List<Team> teams);
        Task<List<Groupe>> getListGroupes(Guid tournamentId);

        Task assignCapgeminiListsToTournament(List<Capgemini> pCapgeminiList,Tournament pTournament);
    }
}
