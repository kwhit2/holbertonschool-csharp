using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> intList = new LinkedList<int>();
        for (int i = size - 1; i >= 0; i--)
        {
            intList.AddFirst(i);
        }
        foreach (int value in intList)
        {
            Console.WriteLine(value.ToString());
        }
        return intList;
    }
}
