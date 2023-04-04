using Log4U.Core.Appenders.Interfaces;
using Log4U.Core.Enums;
using Log4U.Core.IO;
using Log4U.Core.IO.Interfaces;
using Log4U.Core.Layouts.Interfaces;
using Log4U.Core.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4U.Core.Appenders
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ILogFile logFile, ReportLevel reportLevel)
        {
            Layout = layout;
            LogFile = logFile;
            ReportLevel = reportLevel;
        }

        public ILayout Layout { get; private set; }

        public ILogFile LogFile { get; private set; }

        public ReportLevel ReportLevel { get; set; }

        public int MessagesAppended {get; private set; }

        public void AppendMessage(IMessage message)
        {
            string content =
                string.Format(Layout.Format, message.CreatedTime, message.ReportLevel, message.Text);

            LogFile.WriteLine(content);

            File.AppendAllText("text.txt", content + Environment.NewLine);

            MessagesAppended++;
        }
    }
}
