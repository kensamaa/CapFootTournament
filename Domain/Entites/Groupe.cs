using System;
using Domain.Common;

namespace Domain.Entites;

public sealed class Groupe:Entity
{
    public Guid TournamentId { get; set; }
    public string Name { get; set; } = string.Empty;
}

