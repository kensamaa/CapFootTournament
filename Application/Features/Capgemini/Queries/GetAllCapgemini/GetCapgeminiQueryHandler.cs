using System;
using Application.Contracts.Logging;
using Application.Contracts.Repository;
using AutoMapper;
using MediatR;
namespace Application.Features.Capgemini.Queries.GetAllCapgemini;

public class GetCapgeminiQueryHandler : IRequestHandler<GetCapgeminiQuery, List<CapgeminiDto>>
{
    private readonly ICapgeminiRepository _capgeminiRepository;
    private readonly IMapper _mapper;
    private IAppLogger<GetCapgeminiQueryHandler> _Logger { get; }
    public GetCapgeminiQueryHandler(IMapper mapper, ICapgeminiRepository capgeminiRepository,IAppLogger<GetCapgeminiQueryHandler> logger)
    {
        this._mapper = mapper;
        this._capgeminiRepository = capgeminiRepository;
        _Logger = logger;
    }



    public async Task<List<CapgeminiDto>> Handle(GetCapgeminiQuery request, CancellationToken cancellationToken)
    {
        //query database
        var Capgeminis = await _capgeminiRepository.GetAsync();

        //convert data object to dto object
        var data = _mapper.Map<List<CapgeminiDto>>(Capgeminis);

        //return dto object
        _Logger.LogInformation("capgeminis were retrieved succesfully");
        return data;
    }
}

