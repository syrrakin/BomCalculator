using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLib.Messages
{
    public class StringLog
    {
        public string Message { get; }
        public StringLog(string message)
        {
            Message = message;
        }
    }
}
