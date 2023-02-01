using Application.Features.Capgemini.Queries.GetAllCapgemini;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tournament.Queries.GetAllTournaments;

public record GetTournamentQuery : IRequest<List<TournamentDto>>;
