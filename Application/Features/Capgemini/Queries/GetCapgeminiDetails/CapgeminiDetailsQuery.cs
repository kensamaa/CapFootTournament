using MediatR;

namespace Application.Features.Capgemini.Queries.GetCapgeminiDetails;

public record CapgeminiDetailsQuery(Guid Id): IRequest<CapgeminiDetailsDto>;

