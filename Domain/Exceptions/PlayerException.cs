using System.Runtime.Serialization;

namespace Domain.Exceptions;

[Serializable]
public sealed class PlayerException : Exception
{
    public PlayerException(string name, object key) : base($"{name} ({key}) was not found")
    {
    }

    public PlayerException(string? message) : base(message)
    {
    }

    public PlayerException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public PlayerException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
