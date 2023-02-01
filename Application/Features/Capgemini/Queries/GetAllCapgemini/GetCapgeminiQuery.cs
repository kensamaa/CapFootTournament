using System;
using MediatR;
namespace Application.Features.Capgemini.Queries.GetAllCapgemini;

public record GetCapgeminiQuery: IRequest<List<CapgeminiDto>>;


