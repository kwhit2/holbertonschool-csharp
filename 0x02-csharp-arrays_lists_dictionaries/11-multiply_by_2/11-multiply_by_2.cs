using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        var dictedX2 = new Dictionary<string, int>();
        foreach (var item in myDict)
        {
            dictedX2.Add(item.Key, item.Value * 2);
        }
        return (dictedX2);
    }
}
