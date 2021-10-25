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
        public T value;
        public Node next;
        public Node(T n)
        {
            value = n;
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
            T value = head.value;
            head = head.next;
            count--;
            return value;
        }
    }

    ///<summary> Peek() Method </summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }

    ///<summary> Print() Method </summary>
    public void Print()
    {
        Node current = head;

        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }

        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }

    ///<summary> Concatenate() Method </summary>
    public string Concatenate()
    {   
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        string stringFormat = "";

        Node current = head;

        while (current != null)
        {
            stringFormat += current.value.ToString();

            if (current != tail && typeof(T) == typeof(string))
            {
                stringFormat += " ";
            }
            current = current.next;
        }
        return stringFormat;
    }
}
