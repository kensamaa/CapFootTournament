
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
        }
    }
}
