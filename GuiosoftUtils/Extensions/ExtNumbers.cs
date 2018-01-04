using System;

namespace Guiosoft.Extensions
{
    public static class ExtNumbers
    {
        /// <summary>
        /// Returns if a double value is pratical zero 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimals"></param>
        /// <returns></returns>
        public static bool IsZero(this double value, int decimals = 2)
        {
            if (decimals < 0 || decimals > 32)
                throw new ArgumentOutOfRangeException("decimals", "range to decimals is 0 to 32");
            return Math.Round(value, decimals) == 0;
        }

        /// <summary>
        /// Returns if a decimal value is pratical zero 
        /// </summary>
        /// <param name="value"></param>
        /// <param name="decimals"></param>
        /// <returns></returns>
        public static bool IsZero(this decimal value, int decimals = 2)
        {
            if (decimals < 0 || decimals > 32)
                throw new ArgumentOutOfRangeException("decimals", "range to decimals is 0 to 32");
            return Math.Round(value, decimals) == 0;
        }

        /// <summary>
        /// Returns string representation of double value to use in SQL expression
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToSQL(this double value) =>
            value.ToString(System.Globalization.CultureInfo.InvariantCulture);

        /// <summary>
        /// Returns string representation of decimal value to use in SQL expression
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToSQL(this decimal value)=>
            value.ToString(System.Globalization.CultureInfo.InvariantCulture);
    }
}
