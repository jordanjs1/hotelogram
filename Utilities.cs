using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotelogram
{
    /// <summary>
    /// Defines some useful methods used throughout the program.
    /// </summary>
    public static class Utilities
    {
        /// <summary>
        /// Splits the specified string into equal sized substrings.
        /// </summary>
        /// <param name="input">The input string to be split.</param>
        /// <param name="chunkSize">The chunk size.</param>
        /// <returns>Returns a string array with split strings for each index.</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static string[] Split(string input, int chunkSize)
        {
            var stringAfterDivide = string.Empty;

            var stringLength = input.Length;
            for (var i = 0; i < stringLength; i += chunkSize)
            {
                if (i + chunkSize > stringLength) chunkSize = stringLength - i;
                stringAfterDivide += input.Substring(i, chunkSize) + " ";
                 
            }
            return stringAfterDivide.Split(' ');
        }
    }
}
