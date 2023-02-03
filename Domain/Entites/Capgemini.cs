using Domain.Common;

namespace Domain.Entites;

public sealed class Capgemini : Entity
{
    public string Name { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public DateTime DateCreation { get; set; }
}

