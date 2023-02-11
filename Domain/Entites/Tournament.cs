using System;
using Domain.Common;

namespace Domain.Entites;

public class Tournament:Entity
{
    public Tournament() {
        this.Capgeminis =  new List<Capgemini>();
    }
    public String Name { get; set; } = string.Empty;
    public String CountryOrganisation { get; set; } = string.Empty;
    public Boolean isStarted { get; set; }= false;
    public Boolean isSignUpCompleted { get; set; }
    public Boolean isFinished { get; set; }
    
    public virtual ICollection<Capgemini> Capgeminis { get; set; }
}

