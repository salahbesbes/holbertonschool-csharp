using System;

namespace Text
{
    /// <summary> Str Class  </summary>
    public class Str
    {
        /// <summary> count every word in a string  </summary>
        /// <param name="s">  phrase  </param>
        /// <returns> nb of words in a string </returns>
        public static int CamelCase(string s)
        {
            if (s == null || s.Equals("")) return 0;

            bool foundWord;
            int count = 1;

            for (int i = 0; i < s.Length; i++)
            {
                foundWord = Char.IsUpper(s[i]);
                if (foundWord == true) count++;
            }
            return count;
        }
    }
}
