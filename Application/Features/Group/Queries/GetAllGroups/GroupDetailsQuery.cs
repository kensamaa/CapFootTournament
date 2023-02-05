using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Group.Queries.GetAllGroups;

public record GroupDetailsQuery(Guid Id) : IRequest<GroupDetailsDto>
{

}
