using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Application.Features.Tournament.Queries.GetTournamentDetails;


public record GetTournamentDetailsQuery(Guid Id) : IRequest<TournamentDetailsDto>;


