using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Domain.Exceptions;

[Serializable]
public class CapgeminiException : Exception
{
    public CapgeminiException(string name ,object key):base($"{name} ({key}) was not found")
    {
    }

    public CapgeminiException(string? message) : base(message)
    {
    }

    public CapgeminiException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected CapgeminiException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
