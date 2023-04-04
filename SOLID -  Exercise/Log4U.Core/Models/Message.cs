using Log4U.Core.Enums;
using Log4U.Core.Exceptions;
using Log4U.Core.Models.Interfaces;
using Log4U.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log4U.Core.Models
{
    public class Message : IMessage
    {
        private string createdTime;
        private string text;
        public Message(string createdTime, string text, ReportLevel reportLevel)
        {
            CreatedTime = createdTime;
            Text = text;
            ReportLevel = reportLevel;
        }

        public string CreatedTime
        {
            get => createdTime;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new EmptyCreatedTimeException();
                }
                createdTime = value;
            }
        }

        public string Text
        {
            get => text;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new EmptyCreatedTimeException();
                }

                if (DateTimeValidator.ValidateDateTime(value))
                {
                    throw new InvalidTimeException();
                }
                text = value;
            }
        }

        public ReportLevel ReportLevel { get; private set; }
    }
}
