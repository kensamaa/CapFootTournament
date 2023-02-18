using Application.Features.Team.Queries.GetTeams;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class TeamController : ControllerBase
{
	private readonly IMediator _mediator;
	public TeamController(IMediator mediator)
	{
		this._mediator = mediator;
	}
	[HttpGet]
	public async Task<List<TeamDto>> GetTeams()
	{
		var teams = await _mediator.Send(new GetTeamsQuery());
		return teams;
	}
	[HttpGet("{Id}")]
	public async Task<ActionResult<TeamDetailDto>> GetTeam(Guid Id)
	{
		var capgemini = await _mediator.Send(new GetTeamsDetailQuery(Id));
		return Ok(capgemini);
	}
}
