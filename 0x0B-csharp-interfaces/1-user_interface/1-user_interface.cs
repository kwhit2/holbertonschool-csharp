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

///<summary> public method IInteractive() </summary>
public interface IInteractive
{
    ///<summary> public method Interact() </summary>
    void Interact();
}

///<summary> public method IBreakable() </summary>
public interface IBreakable
{
    ///<summary> public property durability </summary>
    int durability { get; set; }

    ///<summary> public method Break() </summary>
    void Break();
}

///<summary> public method ICollectable() </summary>
public interface ICollectable
{
    ///<summary> public property isCollected </summary>
    bool isCollected { get; set; }

    ///<summary> public method Collect() </summary>
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
