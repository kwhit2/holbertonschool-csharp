using System;
using System.Collections.Generic;
using System.Linq;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aStack.Count);
        Console.WriteLine("Top item: {0}", aStack.Peek());
        if (aStack.Count == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        Console.WriteLine("Stack contains \"{0}\": {1}", search, aStack.Contains(search));
        if (aStack.Contains(search))
        {
            int searchIndex = aStack.ToArray().ToList().IndexOf(search);  // how to get index of element at a linked list
            while (aStack.Count > searchIndex - 1)  // - 1 because an extra one was being printed
            {
                aStack.Pop();
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}
