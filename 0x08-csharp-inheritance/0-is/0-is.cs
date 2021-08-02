using System;
using System.Collections.Generic;

///<summary>Class Obj</summary>
class Obj
{
    ///<summary>IsOfTypeInt method</summary>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj is int);
        // return (obj.GetType() == typeof(int));
    }
}
