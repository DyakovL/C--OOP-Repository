using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4U.Core.Exceptions
{
    public class EmptyCreatedTimeException : Exception
    {
        private const string DefaultTextMessage = "Created Text of Message cannot be empty or white space";

        public EmptyCreatedTimeException()
            : base(DefaultTextMessage)
        {

        }


        public EmptyCreatedTimeException(string message) : base(message)
        {

        }
    }
}
