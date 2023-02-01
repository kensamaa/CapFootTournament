using Domain.Common;

namespace Domain.Entites;

public class Capgemini : Entity
{

    string Name { get; set; } = string.Empty;
    string Country { get; set; } = string.Empty;
    string City { get; set; } = string.Empty;
    DateTime DateCreation { get; set; }

   
}

