using System;
using System.Linq;

namespace Text
{
    ///<summary>Str Class</summary>
    public class Str
    {
        ///<summary>UniqueChar method: returns the index of the first non-repeating character of a string.</summary>
        public static int UniqueChar(string s)
        {
            if (s.Length <= 0)
            {
                return -1;
            }
            for (int i = 0; i < s.Length -1; i++)
            {
                if (s[i].ToString() != s[i + 1].ToString())
                {
                    return (i + 1);
                }
            }
            return -1;
        }
    }
}
