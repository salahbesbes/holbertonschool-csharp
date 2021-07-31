using System;
using System.Text;

namespace Text
{
    /// <summary>
    /// class Str
    /// </summary>
    public class Str
    {
        /// <summary> create new string withoud penctuation  </summary>
        /// <param name="input"> bute string </param>
        /// <returns> new string with no punctuation </returns>
        public static string eliminatePunctuation(string input)
        {
            var sb = new StringBuilder();
            foreach (char c in input)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }
            return sb.ToString();
        }
        
        
        /// <summary>  check if th string is palindromic  </summary>
        /// <param name="s"> input </param>
        /// <returns> boolen  </returns>
        public static bool IsPalindrome(string s)
        {
            if (s == null) return false;

            s = s.ToLower();

            // eliminate penctuation
            
            string stripped =  eliminatePunctuation(s);
            stripped = stripped.Replace(" ", "");
            int length = stripped.Length;
            string reverse  = "";

            for (int i = length - 1; i >= 0; i--)
            {
                reverse += stripped[i];
            }
            return stripped.Equals(reverse);
        }
    }
}
