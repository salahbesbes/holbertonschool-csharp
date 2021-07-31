using System;
using System.Linq;

namespace Text
{
    /// <summary> Str Class </summary>
    public class Str
    {
        /// <summary>get nb of occurrence of  a single char in a string</summary>
        /// <param name="input"> string </param>
        /// <param name="character"> char to search occurence </param>
        /// <returns> nb of occurence </returns>
        public static int GetRepeatedNumberChar(string input, char character)
        {
            return input.Count(f => f == character);
        }

        /// <summary> return index of the first non repeating char </summary>
        /// <param name="s"> input string </param>
        /// <returns>index of non repeated char </returns>
        public static int UniqueChar(string s)
        {
            if (s == null) return -1;

            int occurence;
            int i;

            for (i = 0; i < s.Length; i++)
            {
                occurence = GetRepeatedNumberChar(s,s[i]);
                if (occurence == 1) return i;

            }
            
            return -1;
        }
    }
}
