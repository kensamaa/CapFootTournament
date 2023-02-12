using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Features.Capgemini.Queries.GetAllCapgemini;

namespace Application.Features.Tournament.Queries.GetTournamentDetails
{
    public class TournamentDetailsDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateCreation { get; set; }
        public Boolean isStarted { get; set; } = false;
        public Boolean isSignUpCompleted { get; set; }
        public Boolean isFinished { get; set; }
        public String CountryOrganisation { get; set; } = string.Empty;
        public List<CapgeminiDto> ListCapgeminis { get; set; } = new List<CapgeminiDto> { };
    }
}
