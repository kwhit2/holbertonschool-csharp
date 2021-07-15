using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> nNode = new LinkedListNode<int>(n);
        LinkedListNode<int> fakeHeadNode = myLList.First;

        while (fakeHeadNode != null)
        {
            if (fakeHeadNode.Value > nNode.Value)
            {
                myLList.AddBefore(fakeHeadNode, nNode);
                break;
            }
            if (fakeHeadNode.Next == null)
            {
                myLList.AddAfter(fakeHeadNode, nNode);
                break;
            }
            fakeHeadNode =fakeHeadNode.Next;
        }
        return (nNode);
    }
}
