
using System;
using Domain.Common;

namespace Domain.Entites;

public class Team:Entity
{

   
    public string Name { get; set; }
    public Guid GroupeId { get; set; }
    public int Classement { get; set; }
    public int Points { get; set; }
    public string City { get; set; }
   
}

