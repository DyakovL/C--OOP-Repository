using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4U.Core.Exceptions
{
    public class EmptryFileNameExtension : Exception
    {
        private const string DefaultMessage = "File Name can not be null or white space";

        public EmptryFileNameExtension()
            : base(DefaultMessage)
        {

        }


        public EmptryFileNameExtension(string message) : base(message)
        {

        }
    }
}
