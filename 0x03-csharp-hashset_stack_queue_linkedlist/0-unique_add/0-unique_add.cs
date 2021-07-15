using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        List<int> uniqIntList = new List<int>();
        uniqIntList = myList.Distinct().ToList();
        for (int i = 0; i < uniqIntList.Count; i++)
        {
            sum += uniqIntList[i];
        }
        return sum;
    }
}
