
using Application.Features.Capgemini.Commands.CreateCapgemini;
using Application.Features.Capgemini.Commands.UpdateCapgemini;
using Application.Features.Group.Commands.CreateGroup;
using Application.Features.Group.Queries.GetAllGroups;
using Application.Features.Group.Queries.GetGroupDetail;
using AutoMapper;
using Domain.Entites;

namespace Application.MappingProfiles
{
    public class GroupProfile:Profile
    {
        public GroupProfile() {
            CreateMap<GroupDto, Groupe>().ReverseMap();
            CreateMap<Groupe, GroupDetailsDto>();
			CreateMap<CreateGroupCommand, Groupe>();
			CreateMap<UpdateGroupCommand, Groupe>();
		}
    }
}
