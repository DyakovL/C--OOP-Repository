using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4U.Core.Exceptions
{
    public class EmptyCreatedTextException : Exception
    {
        private const string DefaultMessage = "Created Text of Message cannot be empty or white space";

        public EmptyCreatedTextException()
            : base(DefaultMessage) 
        {

        }


        public EmptyCreatedTextException(string message) : base(message)
        {

        }
    }
}
