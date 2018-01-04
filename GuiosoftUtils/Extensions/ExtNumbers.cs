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
        public static string ToSQL(this decimal value) =>
            value.ToString(System.Globalization.CultureInfo.InvariantCulture);

        /// <summary>
        /// Returns if an double value is pratically equals to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="another"></param>
        /// <param name="decimals"></param>
        /// <returns></returns>
        public static bool IsEqual(this double value, double another, int decimals = 2)
        {
            if (decimals < 0 || decimals > 32)
                throw new ArgumentOutOfRangeException("decimals", "range to decimals is 0 to 32");
            return ((int)(value * Math.Pow(10, decimals))) == ((int)(another * Math.Pow(10, decimals)));
        }

        /// <summary>
        /// Returns if an decimal value is pratically equals to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="another"></param>
        /// <param name="decimals"></param>
        /// <returns></returns>
        public static bool IsEqual(this decimal value, decimal another, int decimals = 2)
        {
            if (decimals < 0 || decimals > 32)
                throw new ArgumentOutOfRangeException("decimals", "range to decimals is 0 to 32");
            return ((int)((double)value * Math.Pow(10, (double)decimals))) == ((int)((double)another * Math.Pow(10, (double)decimals)));
        }
    }
}
