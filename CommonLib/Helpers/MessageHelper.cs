using System;
using System.Collections.Generic;
using System.Text;
using Telerik.Windows.Controls;
using System.Windows;
using System.Windows.Controls;
using CommonLib.Messages;

namespace CommonLib.Helpers
{
    public static class MessageHelper
    {
        public static void ShowMessage(Exception ex, string message = null, string header = null, ContentControl owner = null)
        {
            message = StringHelper.MergeStrings("\n\n", message, ex?.Message, ex?.InnerException?.Message);
            header ??= ex == null ? "Предупреждение" : "Ошибка";
            Application.Current.Dispatcher.Invoke(() =>
            {
                RadWindow.Alert(
                                new DialogParameters
                                {
                                    Header = header,
                                    Content = new TextBlock() { Text = message, TextWrapping = TextWrapping.Wrap, Width = 300 },
                                    Owner = owner,
                                    DialogStartupLocation = WindowStartupLocation.CenterOwner
                                });
            });
        }

        public static void ShowMessage(string message, string header = null, ContentControl owner = null)
        {
            ShowMessage(null, message, header, owner);
        }

        public static void ShowMessage(UserMessage userMessage, string header = null, ContentControl owner = null)
        {
            ShowMessage(userMessage.Exception, userMessage.Message, header, owner);
        }



    }
}
