using Application.Features.Group.Queries.GetAllGroups;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Goal.Queries.GetAllGoals
{
	public record GetGoalsQuery : IRequest<List<GoalDto>>;
}
