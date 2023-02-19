using MediatR;

namespace Application.Features.Player.Queries.GetPlayers;

public record GetPlayersQuery : IRequest<List<PlayerDto>>;
