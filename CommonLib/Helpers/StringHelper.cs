using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CommonLib.Helpers
{
    public static class StringHelper
    {
        public static string MergeStrings(string div, params string[] input) => string.Join(div, input.Where(p => p != null && p.Trim() != "").Select(p => p.Trim()));
    }
}
