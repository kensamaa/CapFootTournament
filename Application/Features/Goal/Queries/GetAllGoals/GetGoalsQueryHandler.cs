using Application.Contracts.Repository;
using Application.Features.Group.Queries.GetAllGroups;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Goal.Queries.GetAllGoals
{
	public class GetGoalsQueryHandler : IRequestHandler<GetGoalsQuery, List<GoalDto>>
	{
		private readonly IGoalRepository goalRepository;
		private readonly IMapper mapper;

		public GetGoalsQueryHandler(IGoalRepository goalRepository, IMapper mapper)
		{
			this.goalRepository = goalRepository;
			this.mapper = mapper;
		}
		public Task<List<GoalDto>> Handle(GetGoalsQuery request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
