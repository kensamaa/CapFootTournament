using Application.Contracts.Repository;
using Application.Features.Goal.Queries.GetAllGoals;
using Application.Features.Group.Queries.GetAllGroups;
using AutoMapper;
using MediatR;

namespace Application.Features.Player.Queries.GetPlayerDetails;

public class GetPlayerDetailQueryHandler : IRequestHandler<GetPlayerDetailQuery, PlayerDetailDto>
{
	private readonly IPlayerRepository playerRepository;
	private readonly IMapper mapper;

	public GetPlayerDetailQueryHandler(IPlayerRepository playerRepository,IMapper mapper)
	{
		this.playerRepository = playerRepository;
		this.mapper = mapper;
	}
	public async Task<PlayerDetailDto> Handle(GetPlayerDetailQuery request, CancellationToken cancellationToken)
	{
		var Player = await playerRepository.GetByIdAsync(request.Id);
		var GoalList = await playerRepository.getListGoals(Player.Id);
		var data= mapper.Map<PlayerDetailDto>(Player);
		var GoalDto = mapper.Map<List<GoalDto>>(GoalList);
		data.ListGoals.AddRange(GoalDto);

		return data;
	}
}
