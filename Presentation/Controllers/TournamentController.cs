using Application.Features.Capgemini.Queries.GetAllCapgemini;
using Application.Features.Capgemini.Queries.GetCapgeminiDetails;
using Application.Features.Tournament.Queries.GetAllTournaments;
using Application.Features.Tournament.Queries.GetTournamentDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TournamentController : ControllerBase
	{
        private readonly IMediator _mediator;

        public TournamentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<TournamentDto>> GetTournaments()
        {
            var tournaments = await _mediator.Send(new GetTournamentQuery());
            return tournaments;
        }
		[HttpGet("{Id}")]
		public async Task<ActionResult<TournamentDetailsDto>> GetTournament(Guid Id, CancellationToken cancellationToken)
		{
			var tournamet = await _mediator.Send(new GetTournamentDetailsQuery(Id));
			return Ok(tournamet);
		}
	}
}
