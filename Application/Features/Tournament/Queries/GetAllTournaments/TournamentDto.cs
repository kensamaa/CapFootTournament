using Application.Features.Capgemini.Queries.GetAllCapgemini;
using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tournament.Queries.GetAllTournaments
{
    public class TournamentDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime DateCreation { get; set; }
        public Boolean isStarted { get; set; } = false;
        public Boolean isSignUpCompleted { get; set; }
        public Boolean isFinished { get; set; }
        public String CountryOrganisation { get; set; } = string.Empty;

    }
}
