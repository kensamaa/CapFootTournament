
using Application.Contracts.Repository;
using AutoMapper;
using MediatR;
using System;

namespace Application.Features.Group.Queries.GetAllGroups;

public class GetGroupsQueryHandler : IRequestHandler<GetGroupsQuery, List<GroupDto>>
{
    private readonly IGroupRepository _groupRepository;
    private readonly IMapper _mapper;
     public GetGroupsQueryHandler(IGroupRepository groupRepository , IMapper mapper)
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
    }

    public async Task<List<GroupDto>> Handle(GetGroupsQuery request, CancellationToken cancellationToken)
    {
        var groups = await _groupRepository.GetAsync();
        var data = _mapper.Map<List<GroupDto>>(groups);
        return data;

    }
}
