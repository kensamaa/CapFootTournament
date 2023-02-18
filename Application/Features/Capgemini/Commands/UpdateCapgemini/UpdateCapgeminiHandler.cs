using Application.Contracts.Repository;
using AutoMapper;
using MediatR;

namespace Application.Features.Capgemini.Commands.UpdateCapgemini;

public class UpdateCapgeminiHandler : IRequestHandler<UpdateGroupCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly ICapgeminiRepository _capgeminiRepository;
    public UpdateCapgeminiHandler(IMapper mapper, ICapgeminiRepository capgeminiRepository)
    {
        _mapper = mapper;
        _capgeminiRepository = capgeminiRepository;
    }

    public async Task<Unit> Handle(UpdateGroupCommand request, CancellationToken cancellationToken)
    {
		//validate incoming data

		//convert to domain entity object
		//Domain.Entites.Capgemini cap = new Domain.Entites.Capgemini()
		//{
		//	Name = request.Name,
		//	Country = request.Country,
		//	City = request.City,
		//	NumberOfTeams = request.NumberOfTeams,
		//	DateCreation = request.DateCreation
		//};
		var CapgeminiToUpdate = _mapper.Map<Domain.Entites.Capgemini>(request);
        //update  database
        await _capgeminiRepository.UpdateAsync(CapgeminiToUpdate);
        //return record id
        return Unit.Value;
    }
}
