using System;

///<summary> class Queue </summary>
class Queue<T>
{
    public Node head = null;
    public Node tail = null;
    public int count;

    ///<summary> CheckType method </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    ///<summary> Class Node Method </summary>
    public class Node
    {
        public T data;
        public Node next;
        public Node(T data)
        {
            this.data = data;
        }
    }

    ///<summary> Enqueue() Method </summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else if (tail == null)
        {
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    ///<summary> Count() Method </summary>
    public int Count()
    {
        return count;
    }

    ///<summary> Dequeue() Method </summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            T value = head.data;
            head = head.next;
            count--;
            return value;
        }
    }
}
