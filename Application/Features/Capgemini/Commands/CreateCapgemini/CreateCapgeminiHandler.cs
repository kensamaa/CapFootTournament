using Application.Contracts.Repository;
using AutoMapper;
using Domain.Exceptions;
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
        var validator =new CreateCapgeminiValidator();
        var validationResult = await validator.ValidateAsync(request);
        if (!validationResult.IsValid)
            throw new CapgeminiException("invalid capgemini",validationResult);

        //convert to domain entity object
        var CapgeminiToCreate = _mapper.Map<Domain.Entites.Capgemini>(request);
        //add to database
        await _capgeminiRepository.CreateAsync(CapgeminiToCreate);
        //return record id
        return CapgeminiToCreate.Id;
    }
}
