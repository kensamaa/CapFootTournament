using System;
using Domain.Common;

namespace Domain.Entites;

public class Player:Entity
{
   
    public string Name { get; set; }
    public string FamilyName { get; set; }
    public string Email { get; set; }
    public Guid TeamId { get; set; }
    public List<Card> Cards { get; set; }

   
}

