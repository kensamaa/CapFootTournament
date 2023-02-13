using System;
using Domain.Common;

namespace Domain.Entites;

public class Tournament:Entity
{
    public Tournament() {
        this.capgeminiTournament =  new List<CapgeminiTournament>();
        this.ListeGroupes = new List<Groupe>();
    }
    public String Name { get; set; } = string.Empty;
    public String CountryOrganisation { get; set; } = string.Empty;
    public Boolean isStarted { get; set; }= false;
    public Boolean isSignUpCompleted { get; set; }= false;
    public Boolean isFinished { get; set; } = false;

    public virtual List<CapgeminiTournament> capgeminiTournament { get; set; }
    public virtual List<Groupe> ListeGroupes { get; set; }
}

