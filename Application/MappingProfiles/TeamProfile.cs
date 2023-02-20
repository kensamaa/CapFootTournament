using Application.Features.Team.Queries.GetTeams;
using AutoMapper;
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MappingProfiles;

public class TeamProfile:Profile
{
	public TeamProfile()
	{
		CreateMap<TeamDto, Team>().ReverseMap();
		CreateMap<Team, TeamDetailDto>();
	}
}
