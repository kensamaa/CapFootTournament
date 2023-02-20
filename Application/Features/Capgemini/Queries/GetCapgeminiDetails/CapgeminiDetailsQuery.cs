using MediatR;

namespace Application.Features.Capgemini.Queries.GetCapgeminiDetails;

public record CapgeminiDetailQuery(Guid Id): IRequest<CapgeminiDetailsDto>;

