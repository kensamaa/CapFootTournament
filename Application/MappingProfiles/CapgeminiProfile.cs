using System;
using AutoMapper;
using Domain.Entites;
namespace Application.MappingProfiles;

public class CapgeminiProfile :Profile
{
	public CapgeminiProfile()
	{
		CreateMap<CapgeminiDto, Capgemini>().ReverseMap();
	}
}

