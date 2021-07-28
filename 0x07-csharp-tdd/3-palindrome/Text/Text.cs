using System;

namespace Text
{
    ///<summary>Str Class</summary>
    public class Str
    {
        ///<summary>IsPalindrome method: returns True if a string is a palindrome or False if it’s not.</summary>
        public static bool IsPalindrome(string s)
        {
            if (s.Length <= 1)
            {
                return true;
            }
            else
            {
                if (s[0] != s[s.Length - 1])
                {
                    return false;
                }
                else
                {
                    return IsPalindrome(s.Substring(1, s.Length - 2));
                }
            }
        }
    }
}
