using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Contracts.Repository
{
    public interface ICapgeminiTournament : IGenericRepository<Tournament>
    {
        Task<List<Capgemini>> GetAllCapgeminisInTournaments(Guid pIdTournament);
        Task<List<Tournament>> GetAllTournamentsByCapgeminiId(Guid pIdCapgemini);
    }
}
