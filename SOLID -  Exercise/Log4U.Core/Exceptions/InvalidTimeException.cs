using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4U.Core.Exceptions
{
    public class InvalidTimeException : Exception
    {
        private const string InvalidTimeMessage = "Created Time of Message cannot be empty or white space";

        public InvalidTimeException()
            : base(InvalidTimeMessage)
        {

        }


        public InvalidTimeException(string message) 
            : base(message)
        {

        }
    }
}
