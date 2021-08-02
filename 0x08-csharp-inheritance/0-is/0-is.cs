using System;
using System.Collections.Generic;

///<summary>Class Obj</summary>
class Obj
{
    ///<summary>Check if Type Int</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() == typeof(int))
            return true;
        else
            return false;
    }
}
