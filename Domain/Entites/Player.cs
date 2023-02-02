using System;
using Domain.Common;

namespace Domain.Entites;

public class Player:Entity
{
    public string Name { get; set; } = string.Empty;
    public string FamilyName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public Guid TeamId { get; set; }
    public List<Card> Cards { get; set; }

}

