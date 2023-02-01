using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    internal class MatchException : Exception
    {
        public MatchException()
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
}
