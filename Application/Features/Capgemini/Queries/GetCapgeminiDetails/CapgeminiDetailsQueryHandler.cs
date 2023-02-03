using Application.Contracts.Repository;
using AutoMapper;
using MediatR;

namespace Application.Features.Capgemini.Queries.GetCapgeminiDetails;

public class CapgeminiDetailsQueryHandler : IRequestHandler<CapgeminiDetailsQuery, CapgeminiDetailsDto>
{
    private readonly ICapgeminiRepository _capgeminiRepository;
    private readonly IMapper _mapper;
    public CapgeminiDetailsQueryHandler(ICapgeminiRepository capgeminiRepository, IMapper mapper)
    {
        _capgeminiRepository = capgeminiRepository;
        _mapper = mapper;
    }

    public async Task<CapgeminiDetailsDto> Handle(CapgeminiDetailsQuery request, CancellationToken cancellationToken)
    {
        //query database
        var Capgemini = await _capgeminiRepository.GetByIdAsync(request.Id);

        //convert data object to dto object
        var data = _mapper.Map<CapgeminiDetailsDto>(Capgemini);

        //return dto object
        return data;
    }
}
