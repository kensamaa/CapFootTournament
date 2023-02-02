using Application.Contracts.Repository;
using AutoMapper;
using MediatR;

namespace Application.Features.Capgemini.Commands.CreateCapgemini;

public class CreateCapgeminiHandler : IRequestHandler<CreateCapgeminiCommand, Guid>
{
    private readonly IMapper _mapper;
    private readonly ICapgeminiRepository _capgeminiRepository;

    public CreateCapgeminiHandler(IMapper mapper,ICapgeminiRepository capgeminiRepository)
    {
        this._mapper = mapper;
        this._capgeminiRepository = capgeminiRepository;
    }
    public async Task<Guid> Handle(CreateCapgeminiCommand request, CancellationToken cancellationToken)
    {
        //validate incoming data

        //convert to domain entity object
        var CapgeminiToCreate = _mapper.Map<Domain.Entites.Capgemini>(request);
        //add to database
        await _capgeminiRepository.CreateAsync(CapgeminiToCreate);
        //return record id
        return CapgeminiToCreate.Id;
    }
}
