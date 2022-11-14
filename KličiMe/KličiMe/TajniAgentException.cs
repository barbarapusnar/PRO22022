using System;
using System.Runtime.Serialization;

namespace KličiMe
{
 
    internal class TajniAgentException : Exception
    {
        public TajniAgentException()
        {
        }

        public TajniAgentException(string message) : 
            base("Najden tajni agent "+message)
        {
        }

       
    }
}