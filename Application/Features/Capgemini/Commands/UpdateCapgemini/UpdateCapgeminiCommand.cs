using MediatR;

namespace Application.Features.Capgemini.Commands.UpdateCapgemini;

public class UpdateCapgeminiCommand : IRequest<Unit>
{
	public Guid Id { get; set; }
	public string Name { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
	public int NumberOfTeams { get; set; }
	public DateTime DateCreation { get; set; }
}
