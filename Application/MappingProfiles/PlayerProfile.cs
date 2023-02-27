using Application.Features.Player.Queries.GetPlayerDetails;
using Application.Features.Player.Queries.GetPlayers;
using AutoMapper;
using Domain.Entites;

namespace Application.MappingProfiles;

public class PlayerProfile : Profile
{
	public PlayerProfile()
	{
		CreateMap<PlayerDto, Player>().ReverseMap();
		CreateMap<Player, PlayerDetailDto>();
	}
}
