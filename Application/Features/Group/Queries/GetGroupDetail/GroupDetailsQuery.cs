using MediatR;

namespace Application.Features.Group.Queries.GetGroupDetail;

public record GroupDetailsQuery(Guid Id) : IRequest<GroupDetailsDto>
{

}
