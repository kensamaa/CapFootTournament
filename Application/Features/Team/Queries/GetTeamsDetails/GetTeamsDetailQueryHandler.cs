using Application.Contracts.Repository;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Team.Queries.GetTeams
{
	public class GetTeamsDetailQueryHandler : IRequestHandler<GetTeamsDetailQuery, TeamDetailDto>
	{
		public GetTeamsDetailQueryHandler(ITeamRepository teamRepositor ,IMapper mapper)
		{
			TeamRepositor = teamRepositor;
			Mapper = mapper;
		}

		public readonly ITeamRepository TeamRepositor;
		public readonly IMapper Mapper;

		public async Task<TeamDetailDto> Handle(GetTeamsDetailQuery request, CancellationToken cancellationToken)
		{
			//query database
			var Team = await TeamRepositor.GetByIdAsync(request.Id);
			var data =Mapper.Map<TeamDetailDto>(Team);
			return data;
		}
	}
}
