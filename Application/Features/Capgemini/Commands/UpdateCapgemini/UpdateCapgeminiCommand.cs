using MediatR;

namespace Application.Features.Capgemini.Commands.UpdateCapgemini;

public class UpdateTournamentCommand : IRequest<Unit>
{
    public string Name { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public DateTime DateCreation { get; set; }
}
