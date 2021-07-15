using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> combined = new List<int>();
        foreach (int i in list1)
        {
            if (list2.Contains(i))
            {
                continue;
            }
            else
            {
                combined.Add(i);
            }
        }
        foreach (int k in list2)
        {
            if (list1.Contains(k))
            {
                continue;
            }
            else
            {
                combined.Add(k);
            }
        }
        combined.Sort();
        return (combined);
    }
}
