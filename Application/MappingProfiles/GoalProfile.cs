using Application.Features.Goal.Queries.GetAllGoals;
using AutoMapper;
using Domain.Entites;

namespace Application.MappingProfiles;

public class GoalProfile : Profile
{
	public GoalProfile()
	{
		CreateMap<GoalDto, Goal>().ReverseMap();
		CreateMap<Goal, GoalDto>();
	}
}