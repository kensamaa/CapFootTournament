using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public sealed class PlayerException : Exception
    {
        public PlayerException()
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
}
