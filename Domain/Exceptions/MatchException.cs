using System.Runtime.Serialization;

namespace Domain.Exceptions;
[Serializable]
public class MatchException : Exception
{
    public MatchException(string name, object key) : base($"{name} ({key}) was not found")
    {
    }

    public MatchException(string? message) : base(message)
    {
    }

    public MatchException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected MatchException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
