using Application.Contracts.Repository;
using Application.Features.Team.Queries.GetTeams;
using AutoMapper;
using MediatR;

namespace Application.Features.Group.Queries.GetGroupDetail;

public class GroupDetailsQueryHandler : IRequestHandler<GroupDetailsQuery,GroupDetailsDto>
{
    private readonly IGroupRepository _groupRepository;
    private readonly IMapper _mapper;

    public GroupDetailsQueryHandler(IGroupRepository groupRepository, IMapper mapper)
    {
        _groupRepository = groupRepository;
        _mapper = mapper;
    }

    public async Task<GroupDetailsDto> Handle(GroupDetailsQuery request, CancellationToken cancellationToken)
    {
        //query database
        var Group = await _groupRepository.GetByIdAsync(request.Id);

        var teamList = await _groupRepository.getListTeam(Group.Id);

        var teamDto = _mapper.Map<List<TeamDto>>(teamList);

        //convert data object to dto object
        var data = _mapper.Map<GroupDetailsDto>(Group);
        data.ListeTeams.AddRange(teamDto);

        //return dto object
        return data;
    }
}
