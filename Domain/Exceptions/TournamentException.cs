using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain.Exceptions
{
    public class TournamentException : Exception
    {
        public TournamentException(string name, object key) : base($"{name} ({key}) was not found")
        {
        }
    }
}
