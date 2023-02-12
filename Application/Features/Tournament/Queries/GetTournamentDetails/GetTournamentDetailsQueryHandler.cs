
using Application.Contracts.Repository;
using AutoMapper;
using MediatR;

using Application.Features.Tournament.Queries.GetTournamentDetails;
using Application.Features.Capgemini.Queries.GetAllCapgemini;
namespace Application.Features.Tournament.Queries.GetTournamentDetails;
public class GetTournamentDetailsQueryHandler : IRequestHandler<GetTournamentDetailsQuery, TournamentDetailsDto>
{
    private readonly ITournamentRepository _tournamentRepository;
    private readonly ICapgeminiTournament _tournamentCapgeminiRepository;
    private readonly IMapper _mapper;
    public GetTournamentDetailsQueryHandler(ITournamentRepository tournamentRepository, IMapper mapper, ICapgeminiTournament tournamentCapgeminiRepository)
    {
        this._mapper = mapper;
        this._tournamentRepository = tournamentRepository;
        this._tournamentCapgeminiRepository = tournamentCapgeminiRepository;
    }
    async Task<TournamentDetailsDto> IRequestHandler<GetTournamentDetailsQuery, TournamentDetailsDto>.Handle(GetTournamentDetailsQuery request, CancellationToken cancellationToken)
    {
        //query database
        var Tournament = await _tournamentRepository.GetByIdAsync(request.Id);


        //extract Capgemini List Of Each tournament
        var capgeminiList = await _tournamentCapgeminiRepository.GetAllCapgeminisInTournaments(Tournament.Id);
        var capgeminisDTO = _mapper.Map<List<CapgeminiDto>>(capgeminiList);

        var data = _mapper.Map<TournamentDetailsDto>(Tournament);
        data.ListCapgeminis.AddRange(capgeminisDTO);

        //return dto object
        return data;
    }
}
