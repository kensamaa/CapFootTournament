using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using System.Threading.Tasks;
using Application.Contracts.Repository;
using Application.Features.Capgemini.Queries.GetAllCapgemini;

namespace Application.Features.Team.Queries.GetTeams
{
	public class GetTeamsQueryHandler : IRequestHandler<GetTeamsQuery,List<TeamDto>>
	{
		public GetTeamsQueryHandler(ITeamRepository teamRepository, IMapper mapper) {
			TeamRepository = teamRepository;
			Mapper = mapper;
		}

		public readonly ITeamRepository TeamRepository;
		public readonly IMapper Mapper;

		public async Task<List<TeamDto>> Handle(GetTeamsQuery request, CancellationToken cancellationToken)
		{
			var Teams = await TeamRepository.GetAsync();

			//convert data object to dto object
			var data = Mapper.Map<List<TeamDto>>(Teams);

			//return dto object
			return data;
		}
	}
}
