using Application.Contracts.Repository;
using Application.Features.Team.Queries.GetTeams;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Player.Queries.GetPlayers
{
	public class GetPlayersQueryHandler : IRequestHandler<GetPlayersQuery, List<PlayerDto>>
	{
		private readonly IPlayerRepository playerRepository;
		private readonly IMapper mapper;

		public GetPlayersQueryHandler(IPlayerRepository playerRepository, IMapper mapper)
		{
			this.playerRepository = playerRepository;
			this.mapper = mapper;
		}
		public async Task<List<PlayerDto>> Handle(GetPlayersQuery request, CancellationToken cancellationToken)
		{
			var player = await playerRepository.GetAsync();

			//convert data object to dto object
			var data = mapper.Map<List<PlayerDto>>(player);

			//return dto object
			return data;
		}
	}
}
