using System;
using System.Collections.Generic;

///<summary>Class Obj</summary>
class Obj
{
    ///<summary>IsInstanceOfArray method</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return (typeof(Array).IsInstanceOfType(obj));
    }
}
