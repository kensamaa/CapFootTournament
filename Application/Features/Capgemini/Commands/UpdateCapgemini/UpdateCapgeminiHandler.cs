using Application.Contracts.Repository;
using AutoMapper;
using MediatR;

namespace Application.Features.Capgemini.Commands.UpdateCapgemini;

public class UpdateCapgeminiHandler : IRequestHandler<UpdateTournamentCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly ICapgeminiRepository _capgeminiRepository;
    public UpdateCapgeminiHandler(IMapper mapper, ICapgeminiRepository capgeminiRepository)
    {
        _mapper = mapper;
        _capgeminiRepository = capgeminiRepository;
    }

    public async Task<Unit> Handle(UpdateTournamentCommand request, CancellationToken cancellationToken)
    {
        //validate incoming data

        //convert to domain entity object
        var CapgeminiToUpdate = _mapper.Map<Domain.Entites.Capgemini>(request);
        //update  database
        await _capgeminiRepository.UpdateAsync(CapgeminiToUpdate);
        //return record id
        return Unit.Value;
    }
}
