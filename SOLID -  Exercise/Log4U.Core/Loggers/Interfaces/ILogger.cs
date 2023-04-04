using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Log4U.Core.Loggers.Interfaces
{
    public interface ILogger
    {
        void Info(string dateTime, string text);

        void Warning(string dateTime, string text);

        void Error(string dateTime, string text);

        void Critical(string dateTime, string text);

        void Fatal(string dateTime, string text);
    }
}
