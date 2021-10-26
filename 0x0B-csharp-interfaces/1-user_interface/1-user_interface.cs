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

///<summary> IInteractive method </summary>
public interface IInteractive
{
    void Interact();
}

///<summary> IBreakable method </summary>
public interface IBreakable
{
    int durability { get; set; }
    void Break();
}

///<summary> ICollectable method </summary>
public interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

///<summary> class TestObject </summary>
public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    ///<summary> public property durability </summary>
    public int durability { get; set; } = 1;

    ///<summary> public property isCollected </summary>
    public bool isCollected { get; set; } = false;

    ///<summary> public void method Interact() </summary>
    public void Interact()
    {
    }

    ///<summary> public void method Break() </summary>
    public void Break()
    {
    }

    ///<summary> public void method Collect() </summary>
    public void Collect()
    {
    }
}
