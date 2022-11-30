using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLib.Messages
{
    public class UpdateContentMessage
    {
        public object Content { get; }
        public UpdateContentMessage(object content)
        {
            Content = content;
        }
    }
}
