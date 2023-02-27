using Application.Contracts.Repository;
using Application.Features.Player.Queries.GetPlayers;
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
		public readonly ITeamRepository TeamRepositor;
		public readonly IMapper Mapper;
		public readonly IPlayerRepository PlayerRepository;

		public GetTeamsDetailQueryHandler(ITeamRepository teamRepositor ,IMapper mapper, IPlayerRepository playerRepository)
		{
			TeamRepositor = teamRepositor;
			PlayerRepository = playerRepository;
			Mapper = mapper;
		}


		public async Task<TeamDetailDto> Handle(GetTeamsDetailQuery request, CancellationToken cancellationToken)
		{
			//query database
			var Team = await TeamRepositor.GetByIdAsync(request.Id);
			var playerList = await TeamRepositor.getListPlayers(Team.Id);

			var data =Mapper.Map<TeamDetailDto>(Team);
			var playersDto= Mapper.Map<List<PlayerDto>>(playerList);
			data.Listplayerss.AddRange(playersDto);

			return data;
		}
	}
}
