using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Input;

namespace CommonLib.Helpers
{
    public static class GuiHelper
    {
        public static bool IsDigitKey(Key key)
        {
            return (key >= Key.D0 && key <= Key.D9) || (key >= Key.NumPad0 && key <= Key.NumPad9);
        }

        public static T TryFindVisualParentByType<T>(DependencyObject child) where T : class
        {
            if (child == null) { return null; }
            try
            {
                var parent = VisualTreeHelper.GetParent(child);
                if (parent == null) { return null; }
                if (parent is T)
                {
                    return parent as T;
                }
                else
                {
                    return TryFindVisualParentByType<T>(parent);
                }
            }
            catch
            {
                return null;
            }
        }
        public static T TryFindFirstVisualChildByType<T>(DependencyObject parent) where T : class
        {
            if (parent == null) { return null; }
            return TryFindVisualChildsByType<T>(parent)?.FirstOrDefault();
        }

        public static IEnumerable<T> TryFindVisualChildsByType<T>(DependencyObject parent) where T : class
        {
            if (parent == null) { return null; }
            var childs = new List<T>();
            try
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
                {
                    var child = VisualTreeHelper.GetChild(parent, i);
                    if (child != null)
                    {
                        if (child is T)
                        {
                            childs.Add(child as T);
                        }
                        else
                        {
                            childs.AddRange(TryFindVisualChildsByType<T>(child));
                        }
                    }
                }
                return childs;
            }
            catch
            {
                return null;
            }
        }
    }
}
