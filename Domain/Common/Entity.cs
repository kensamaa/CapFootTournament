using System;
namespace Domain.Common;

public abstract class Entity
{
	public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public String CountryOrganisation { get; set; } = string.Empty;
    public DateTime? DateCreated { get; set; }
	public DateTime? DateModified { get; set; }
}

