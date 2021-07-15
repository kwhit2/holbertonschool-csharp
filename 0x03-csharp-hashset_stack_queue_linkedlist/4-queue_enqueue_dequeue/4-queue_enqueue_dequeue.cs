using System;
using System.Collections.Generic;
using System.Linq;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: " + aQueue.Count);

        if (aQueue.Count != 0)
        {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }
        if (aQueue.Count == 0)
        {
            Console.WriteLine("Queue is empty");
        }
        Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));
        if (aQueue.Contains(search))
        {
            int searchIndex = aQueue.ToArray().ToList().IndexOf(search);  // how to get index of element at a linked list
            while (aQueue.Count > searchIndex + 1)
            {
                aQueue.Dequeue();
            }
        }
        aQueue.Enqueue(newItem);
        return (aQueue);
    }
}
