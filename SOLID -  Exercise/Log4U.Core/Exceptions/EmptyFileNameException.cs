using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4U.Core.Exceptions
{
    public class EmptyFileNameException : Exception
    {
        private const string DefaultMessage = "File Name can not be null or white space";

        public EmptyFileNameException()
            : base(DefaultMessage)
        {

        }


        public EmptyFileNameException(string message) : base(message)
        {

        }
    }
}
