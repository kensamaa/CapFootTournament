using Application.Contracts.Repository;
using Application.Features.Capgemini.Queries.GetAllCapgemini;
using AutoMapper;
using Domain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tournament.Queries.GetAllTournaments
{
    public class GetTournamentQueryHandler : IRequestHandler<GetTournamentQuery, List<TournamentDto>>
    {
        private readonly ITournamentRepository _tournamentRepository;
        private readonly IMapper _mapper;

        public GetTournamentQueryHandler(IMapper mapper, ITournamentRepository tournamentRepository)
        {
            this._mapper = mapper;
            this._tournamentRepository = tournamentRepository;
        }

        async Task<List<TournamentDto>> IRequestHandler<GetTournamentQuery, List<TournamentDto>>.Handle(GetTournamentQuery request, CancellationToken cancellationToken)
        {
            //query database
            var Tournaments = await _tournamentRepository.GetAllTournaments();
            CapgeminiDto capgeminiItem;
            //convert data object to dto object
            var data = _mapper.Map<List<TournamentDto>>(Tournaments);
            foreach(var tournament in data)
            {
                capgeminiItem = new CapgeminiDto();

                tournament.ListCapgeminis.Add(Tournaments.Where(t=>t.Id == tournament.Id).Select(t=>t.capgeminiTournament.Where(ct=>ct.tournamentId == t.Id).Select(ct=>ct.capgemini).FirstOrDefault<Capgemini>())
            }
            //return dto object
            return data;
        }
    }
}
