﻿using Domain.Common;

namespace Domain.Entites;

public sealed class Team:Entity
{
    public string Name { get; set; } = string.Empty;
    public Guid GroupeId { get; set; }
    public int Classement { get; set; }
    public int Points { get; set; }
    public string City { get; set; } = string.Empty;
    public Guid CapgeminiId { get; set; }

}

