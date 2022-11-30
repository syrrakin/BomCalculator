using System;
using System.Collections.Generic;
using System.Text;

namespace CommonLib.Messages
{
    public class GuiStateMessage
    {
        public bool IsEnabled { get; }
        public string Status { get; }

        public GuiStateMessage(bool isEnabled = true, string status = "")
        {
            IsEnabled = isEnabled;
            Status = status;
        }
    }
}
