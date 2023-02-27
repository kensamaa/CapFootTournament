using MediatR;

namespace Application.Features.Player.Queries.GetPlayerDetails
{
	public record GetPlayerDetailQuery(Guid Id) : IRequest<PlayerDetailDto>;
}
