using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class ConcatedString
    {
        /// <summary>
        /// Concats two strings, sorts result and deletes repeating elements.
        /// </summary>
        /// <param name="firstString">String contains only letters.</param>
        /// <param name="secondString">String contains only letters.</param>
        public static string MakeString(string firstString, string secondString)
        {
            if (String.IsNullOrEmpty(firstString))
                throw new ArgumentException($"Argument {nameof(firstString)} is null or empty.");

            if (String.IsNullOrEmpty(secondString))
                throw new ArgumentException($"Argument {nameof(secondString)} is null or empty.");

            if (!firstString.All(c => char.IsLetter(c)))
                throw new ArgumentException($"Argument {nameof(firstString)} contains not only letters.");

            if (!secondString.All(c => char.IsLetter(c)))
                throw new ArgumentException($"Argument {nameof(secondString)} contains not only letters.");
            
                string concatString = string.Concat(firstString, secondString);
                char[] arr = concatString.ToCharArray();
                arr = arr.Distinct().ToArray();
                Array.Sort(arr);
                string resultString = new string(arr, 0, arr.Length);
                return resultString;
        }
    }
}
