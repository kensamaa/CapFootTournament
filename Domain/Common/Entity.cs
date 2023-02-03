﻿using System;
namespace Domain.Common;

public abstract class Entity : IEquatable<Entity>
{
	public Guid Id { get; set; }
    public DateTime? DateCreated { get; set; }
	public DateTime? DateModified { get; set; }
    public override bool Equals(object? obj)
    {
        if (obj == null) return false;
        if(obj.GetType() !=GetType()) return false;
        if (obj is not Entity entity) return false;
        return entity.Id == Id;
    }

    public bool Equals(Entity? other)
    {
        if(other== null) return false;
        if(other.GetType() != GetType()) return false;
        return other.Id == Id;
    }
    public static bool operator==(Entity? left, Entity? right)
    {
        return left is not null && right is not null && left.Equals(right);
    }
    public static bool operator !=(Entity? left, Entity? right)
    {
        return !(left == right);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode() * 69;
    }
}

