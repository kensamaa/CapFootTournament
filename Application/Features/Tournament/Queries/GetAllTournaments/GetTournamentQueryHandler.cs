using Application.Contracts.Repository;
using Application.Features.Capgemini.Queries.GetAllCapgemini;
using AutoMapper;
using MediatR;

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

            //convert data object to dto object

            var data = _mapper.Map<List<TournamentDto>>(Tournaments);
            //return dto object
            return data;
        }
    }
}
