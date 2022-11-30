using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CommonLib.Helpers
{
    public static class IEnumerableHelpers
    {
        public static IEnumerable<T> NotNull<T>(this IEnumerable<T> source) => source.Where(p => p != null);

        public static IEnumerable<T> Clone<T>(this IEnumerable<T> source) where T : ICloneable
        {
            return source.Select(p => (T)p.Clone());
        }


    }
}
