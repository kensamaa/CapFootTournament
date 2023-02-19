using Application.Features.Player.Queries.GetPlayers;
using AutoMapper;
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MappingProfiles
{
	public class PlayerProfile : Profile
	{
		public PlayerProfile()
		{
			CreateMap<PlayerDto, Player>().ReverseMap();
			//CreateMap<Player, playerDetailDto>();
		}
	}
}
