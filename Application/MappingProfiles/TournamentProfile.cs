using Application.Features.Capgemini.Commands.CreateCapgemini;
using Application.Features.Capgemini.Commands.UpdateCapgemini;
using Application.Features.Tournament.Commands.CreateTournament;
using Application.Features.Tournament.Commands.UpdateTournament;
using Application.Features.Tournament.Queries.GetAllTournaments;
using Application.Features.Tournament.Queries.GetTournamentDetails;
using AutoMapper;
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MappingProfiles;

public class TournamentProfile : Profile
{
    public TournamentProfile()
    {
        CreateMap<TournamentDto, Tournament>().ReverseMap();
        CreateMap<Tournament, TournamentDetailsDto>();
			CreateMap<CreateTournamentCommand, Tournament>();
			CreateMap<UpdateTournamentCommand, Tournament>();
		}
}
