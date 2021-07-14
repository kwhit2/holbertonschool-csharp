using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
        {
            return ("None");
        }
        var max = myList.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        // ^ no idea. Below is the link
        // https://stackoverflow.com/questions/2805703/good-way-to-get-the-key-of-the-highest-value-of-a-dictionary-in-c-sharp
        return (max);
    }
}
