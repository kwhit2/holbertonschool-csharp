using System;
///<summary> abstract class Base</summary>
public abstract class Base
{
    ///<summary> public property name</summary>
    public string name { get; set; }

    ///<summary> ToString() override method</summary>
    public override string ToString()
    {
        return (this.name) + " is a " + (this.GetType());
    }
}
