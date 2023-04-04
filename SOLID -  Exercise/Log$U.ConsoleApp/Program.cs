using Log4U.ConsoleApp.CustomLayouts;
using Log4U.Core.Appenders;
using Log4U.Core.Appenders.Interfaces;
using Log4U.Core.Enums;
using Log4U.Core.IO;
using Log4U.Core.IO.Interfaces;
using Log4U.Core.Layouts;
using Log4U.Core.Layouts.Interfaces;
using Log4U.Core.Loggers;
using Log4U.Core.Loggers.Interfaces;
using Log4U.Core.Utils;
using Microsoft.VisualBasic;

namespace Log4U.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xmlLayout = new XmlLayout();
            var consoleAppender = new ConsoleAppender(xmlLayout);
            var logger = new Logger(consoleAppender);

            logger.Fatal("3/31/2015 5:23:54 PM", "mscorlib.dll does not respond");
            logger.Critical("3/31/2015 5:23:54 PM", "No connection string found in App.config");



        }
    }
}