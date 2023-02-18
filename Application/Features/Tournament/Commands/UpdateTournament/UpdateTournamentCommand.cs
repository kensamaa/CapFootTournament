using Application.Features.Capgemini.Queries.GetAllCapgemini;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tournament.Commands.UpdateTournament
{
    public class UpdateTournamentCommand : IRequest<Unit>
    {
        public String Name { get; set; } = string.Empty;
        public String CountryOrganisation { get; set; } = string.Empty;
        public Boolean isStarted { get; set; } = false;
        public Boolean isSignUpCompleted { get; set; }
        public Boolean isFinished { get; set; }
        public List<CapgeminiDto> ListCapgeminis { get; set; } = new List<CapgeminiDto> { };
    }
}
