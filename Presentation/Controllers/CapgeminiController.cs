﻿using Application.Features.Capgemini.Queries.GetAllCapgemini;
using Application.Features.Capgemini.Queries.GetCapgeminiDetails;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public sealed class CapgeminiController : ControllerBase
{
    private readonly IMediator _mediator;

    public CapgeminiController(IMediator mediator)
    {
        this._mediator = mediator;
    }

    [HttpGet]
    public async Task<List<CapgeminiDto>> GetCapgeminis()
    {
        var capgeminis = await _mediator.Send(new GetCapgeminiQuery());
        return capgeminis;
    }
    [HttpGet("{Id}")]
    public async Task<ActionResult<CapgeminiDto>> GetCapgemini(Guid Id, CancellationToken cancellationToken)
    {
        var capgemini = await _mediator.Send(new CapgeminiDetailsQuery(Id));
        return Ok(capgemini);
    }
}
