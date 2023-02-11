using Application.Features.Capgemini.Queries.GetAllCapgemini;
using Domain.Entites;
using MediatR;


namespace Application.Features.Tournament.Commands.CreateTournament
{
    public class CreateTournamentCommand : IRequest<Guid>
    {
        public String Name { get; set; } = string.Empty;
        public String CountryOrganisation { get; set; } = string.Empty;
        public Boolean isStarted { get; set; } = false;
        public Boolean isSignUpCompleted { get; set; }
        public Boolean isFinished { get; set; }
        public List<CapgeminiDto> ListCapgeminis { get; set; } = new List<CapgeminiDto> { };
    }
}
