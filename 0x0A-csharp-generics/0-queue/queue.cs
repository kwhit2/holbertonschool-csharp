using System;

///<summary> class Queue </summary>
class Queue<T>
{
    ///<summary> CheckType method </summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
