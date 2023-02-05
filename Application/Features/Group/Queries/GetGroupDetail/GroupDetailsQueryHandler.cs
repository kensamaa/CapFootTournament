using Application.Contracts.Repository;
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

        //convert data object to dto object
        var data = _mapper.Map<GroupDetailsDto>(Group);

        //return dto object
        return data;
    }
}
