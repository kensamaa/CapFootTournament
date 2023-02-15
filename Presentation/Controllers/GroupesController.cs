using Application.Features.Capgemini.Commands.CreateCapgemini;
using Application.Features.Capgemini.Commands.DeleteCapgemini;
using Application.Features.Capgemini.Queries.GetAllCapgemini;
using Application.Features.Capgemini.Queries.GetCapgeminiDetails;
using Application.Features.Group.Commands.CreateGroup;
using Application.Features.Group.Commands.DeleteGroup;
using Application.Features.Group.Queries.GetAllGroups;
using Application.Features.Group.Queries.GetGroupDetail;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers;
[Route("api/[controller]")]
[ApiController]
public sealed class GroupesController : ControllerBase
{
	private readonly IMediator _mediator;
	public GroupesController(IMediator mediator)
	{
		this._mediator = mediator;
	}
	[HttpGet]
	public async Task<List<GroupDto>> GetGroupes()
	{
		var groupes = await _mediator.Send(new GetGroupsQuery());
		return groupes;
	}
	[HttpGet("{Id}")]
	public async Task<ActionResult<GroupDetailsDto>> GetGroupe(Guid Id)
	{
		var group = await _mediator.Send(new GroupesDetailQuery(Id));
		return Ok(group);
	}
	[HttpPost]
	[ProducesResponseType(201)]
	[ProducesResponseType(400)]
	public async Task<ActionResult> AddGroup(CreateGroupCommand group)
	{
		var response = await _mediator.Send(group);
		return CreatedAtAction(nameof(AddGroup), new { id = response });
	}
	[HttpDelete]
	[ProducesResponseType(StatusCodes.Status204NoContent)]
	[ProducesResponseType(StatusCodes.Status404NotFound)]
	[ProducesDefaultResponseType]
	public async Task<ActionResult> DeleteGroup(Guid Id)
	{
		var command = new DeleteGroupCommand { Id = Id };
		await _mediator.Send(command);
		return NoContent();
	}

}
