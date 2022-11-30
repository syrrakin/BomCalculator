using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLib.Messages
{
    public class UserMessage
    {
        public string Message { get; }
        public Exception Exception { get; }

        public UserMessage(string message)
        {
            Message = message;
            Exception = null;            
        }

        public UserMessage(Exception exception, string message = null)
        {
            Exception = exception;
            Message = message;
        }
    }
}
