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

///<summary> class Door </summary>
public class Door : Base, IInteractive
{
    ///<summary> public constructor </summary>
    public Door(string name = "Door")
    {
        this.name = name;
    }

    ///<summary> public method Interact() </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}
