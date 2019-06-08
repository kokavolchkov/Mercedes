using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WireAutomation.Helpers
{
    public static class DataHelper
    {
        /// <summary>
        /// Method corverts string number for example "1" to int number 1
        /// </summary>
        /// <param name="numberString"></param>
        /// <returns>int</returns>
        public static int WordToInt(string numberString)
        {
            return Convert.ToInt32(numberString);
        }

        /// <summary>
        /// Method corverts string number for example "1" to float number 1
        /// </summary>
        /// <param name="numberString"></param>
        /// <returns>float</returns>
        public static float StringToFloat(string numberString)
        {
            return float.Parse(numberString, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Method trims all characters from the line except numbers and delimeters
        /// </summary>
        /// <param name="numberString"></param>
        /// <returns>string</returns>
        public static string GetOnlyDigitsFromString(string numberString)
        {
            var newString = Regex.Replace(numberString, "[^.0-9]", "");
            return newString;
        }
    }
}
