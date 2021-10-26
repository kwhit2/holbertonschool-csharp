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
