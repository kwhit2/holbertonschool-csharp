using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;

        foreach (int values in myLList)
        {
            sum += values;
        }
        return (sum);
        // or just use LINQ Namespace and: return myLList.Sum();
    }
}
