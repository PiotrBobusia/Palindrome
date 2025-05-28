using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class PalindromeVerifier
    {
        public static Boolean isPalindrome(string value)
        {
            string resultString = "";

            foreach(char c in value)
            {
                if (char.IsLetterOrDigit(c))
                {
                    resultString += c;
                }
            }

            return String.Equals(resultString, reverseString(resultString), StringComparison.OrdinalIgnoreCase);
        }

        private static string reverseString(string value)
        {
            char[] charArray = value.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
