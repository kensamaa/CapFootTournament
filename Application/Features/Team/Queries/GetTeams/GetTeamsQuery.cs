using MediatR;

namespace Application.Features.Team.Queries.GetTeams;

public record GetTeamsQuery :IRequest<List<TeamDto>>;
