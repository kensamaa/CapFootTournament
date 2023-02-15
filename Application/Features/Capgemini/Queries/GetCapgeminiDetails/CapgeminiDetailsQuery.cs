using MediatR;

namespace Application.Features.Capgemini.Queries.GetCapgeminiDetails;

public record GroupesDetailQuery(Guid Id): IRequest<CapgeminiDetailsDto>;

