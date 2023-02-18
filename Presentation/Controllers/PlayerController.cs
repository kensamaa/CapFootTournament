using Application.Features.Player.Queries.GetPlayers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PlayerController : ControllerBase
	{
		private readonly IMediator _mediator;
		public PlayerController(IMediator mediator)
		{
			this._mediator = mediator;
		}
		[HttpGet]
		public async Task<List<PlayerDto>> GetTeams()
		{
			var teams = await _mediator.Send(new GetPlayersQuery());
			return teams;
		}
	}
}
