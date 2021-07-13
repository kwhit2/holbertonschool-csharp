using System;

class Character
{
    public static bool IsLower(char c)
    // Returns True if c is lowercase, Returns False otherwise
    {
        if (c >= 'a' && c <= 'z')
        {
            return (true);
        }
        else
        {
            return (false);
        }
    }
}
