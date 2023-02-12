using System;
using Domain.Common;

namespace Domain.Entites;

public class Tournament:Entity
{
    public Tournament() {
        this.capgeminiTournament =  new List<CapgeminiTournament>();
    }
    public String Name { get; set; } = string.Empty;
    public String CountryOrganisation { get; set; } = string.Empty;
    public Boolean isStarted { get; set; }= false;
    public Boolean isSignUpCompleted { get; set; }
    public Boolean isFinished { get; set; }
    
    public virtual List<CapgeminiTournament> capgeminiTournament { get; set; }
}

