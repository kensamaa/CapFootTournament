using System;
using Domain.Common;

namespace Domain.Entites;

public sealed class Tournament:Entity
{
    public String Name { get; set; } = string.Empty;
    public String CountryOrganisation { get; set; } = string.Empty;
}

