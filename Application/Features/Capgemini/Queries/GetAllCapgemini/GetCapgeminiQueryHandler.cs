using System;
using Application.Contracts.Repository;
using AutoMapper;
using MediatR;
namespace Application.Features.Capgemini.Queries.GetAllCapgemini;

public class GetCapgeminiQueryHandler : IRequestHandler<GetCapgeminiQuery, List<CapgeminiDto>>
{
    private readonly ICapgeminiRepository _capgeminiRepository;
    private readonly IMapper _mapper;

    public GetCapgeminiQueryHandler(IMapper mapper, ICapgeminiRepository capgeminiRepository)
    {
        this._mapper = mapper;
        this._capgeminiRepository = capgeminiRepository;
    }


    public async Task<List<CapgeminiDto>> Handle(GetCapgeminiQuery request, CancellationToken cancellationToken)
    {
        //query database
        var Capgeminis = await _capgeminiRepository.GetAsync();

        //convert data object to dto object
        var data = _mapper.Map<List<CapgeminiDto>>(Capgeminis); 

        //return dto object
        return data;
    }
}

