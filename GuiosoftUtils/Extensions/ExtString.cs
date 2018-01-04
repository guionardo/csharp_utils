using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guiosoft.Extensions
{
    public static class ExtString
    {
        /// <summary>
        /// Replaces contents in string, searching by values in array
        /// </summary>
        /// <param name="str"></param>
        /// <param name="searched"></param>
        /// <param name="replaced"></param>
        /// <param name="comparisonType"></param>
        /// <param name="limitByElements"></param>
        /// <returns></returns>
        public static string Replace(this string str, string[] searched, string[] replaced, StringComparison comparisonType = StringComparison.CurrentCulture, int limitByElements = 256)
        {
            if (searched == null || searched.Length < 1)
                throw new NullReferenceException("searched array must have at least one element");
            if (replaced == null || replaced.Length != searched.Length)
                throw new NullReferenceException("replaced array must have identical number of elements of searched array");

            if (limitByElements < 0)
                throw new ArgumentOutOfRangeException("limitByElements", "limit cannot be negative number");

            if (limitByElements == 0)
                limitByElements = 102400;   // Limit to avoid endless loop

            for (int i = 0; i < searched.Length; i++)
                if (string.IsNullOrEmpty(searched[i]))
                    continue;
                else
                {
                    int p = str.IndexOf(searched[i], comparisonType);
                    int limit = 0;
                    while (p > -1 && limit < limitByElements)
                    {
                        if (p == 0)
                            str = (replaced[i] ?? "") + str.Substring(searched[i].Length);
                        else
                            str = str.Substring(0, p) + (replaced[i] ?? "") + str.Substring(p + searched[i].Length);
                        int p2 = str.IndexOf(searched[i], comparisonType);
                        if (p2 <= p)
                            p = str.IndexOf(searched[i], p + 1, comparisonType);
                        else
                            p = p2;                        
                        limit++;
                    }
                }

            return str;
        }

    }
}
