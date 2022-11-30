using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;

namespace CommonLib.Helpers
{
    public static class ObservableCollectionHelper
    {
        public static void SafeAdd<T>(this ObservableCollection<T> collection, T item)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                collection.Add(item);
            });
        }

        public static void AddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> range)
        {
            foreach (T item in range)
            {
                collection.Add(item);
            }
        }

        public static void SafeAddRange<T>(this ObservableCollection<T> collection, IEnumerable<T> range)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                collection.AddRange(range);
            });
        }

        public static void SafeClear<T>(this ObservableCollection<T> collection)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                collection.Clear();
            });
        }

        public static void SafeRemove<T>(this ObservableCollection<T> collection, T item)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                if (collection.Contains(item))
                {
                    collection.Remove(item);
                }
            });
        }
        public static void SafeRemove<T>(this ObservableCollection<T> collection, IEnumerable<T> range)
        {
            System.Windows.Application.Current.Dispatcher.Invoke(() =>
            {
                foreach (T item in range)
                {
                    if (collection.Contains(item))
                    {
                        collection.Remove(item);
                    }
                }
            });
        }

        public static void Move<T>(this ObservableCollection<T> collection, IEnumerable<T> moveItems, int targetIndex)
        {
            moveItems.Where(p => collection.Contains(p)).OrderBy(p => collection.IndexOf(p)).ToList().ForEach(p =>
            {
                int oldIndex = collection.IndexOf(p);
                if (oldIndex < targetIndex)
                {
                    collection.Move(oldIndex, targetIndex - 1);
                }
                else
                {
                    if (oldIndex > targetIndex)
                    {
                        collection.Move(oldIndex, targetIndex);
                    }
                    targetIndex++;
                }
            });
        }
    }
}
