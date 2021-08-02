using System;
using System.Collections.Generic;
using System.Reflection;

///<summary>Class Obj</summary>
class Obj
{
    ///<summary>Print method: prints the names of the available properties and methods of an object</summary>
    public static void Print(object myObj)
    {
        PropertyInfo[] kPropInfo;
        MethodInfo[] kMethInfo;

        kPropInfo = myObj.GetType().GetProperties();
        kMethInfo = myObj.GetType().GetMethods();

        Console.WriteLine("{0} Properties:", myObj.GetType().Name);

        for (int i = 0; i < kPropInfo.Length; i++)
        {
            Console.WriteLine(kPropInfo[i].Name);
        }

        Console.WriteLine("{0} Methods:", myObj.GetType().Name);

        for (int i = 0; i < kMethInfo.Length; i++)
        {
            Console.WriteLine(kMethInfo[i].Name);
        }
    }
}
