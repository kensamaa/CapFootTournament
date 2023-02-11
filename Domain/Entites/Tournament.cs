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
    public virtual ICollection<Capgemini> Capgeminis { get; set; }
}

