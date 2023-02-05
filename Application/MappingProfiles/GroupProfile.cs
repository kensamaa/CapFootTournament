using Application.Features.Group.Queries.GetAllGroups;
using AutoMapper;
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MappingProfiles
{
    public class GroupProfile:Profile
    {
        public GroupProfile() { CreateMap<GroupDetailsDto, Groupe>().ReverseMap(); }   
    }
}
