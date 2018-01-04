using System;

namespace Guiosoft.Extensions
{
    public static class ExtDateTime
    {
        /// <summary>
        /// Returns string representation of DateTime value to use in SQL expression
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToSQL(this DateTime value) =>
            value.ToString("yyyy-MM-dd HH:mm:ss");
    }
}
