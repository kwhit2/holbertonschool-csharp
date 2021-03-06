using System;
using System.Collections.Generic;

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

///<summary> class Decoration </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    ///<summary> public bool isQuestItem </summary>
    public bool isQuestItem;

    ///<summary> public constructor </summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    ///<summary> public property durability </summary>
    public int durability { get; set; }

    ///<summary> public method Interact() </summary>
    public void Interact()
    {
        if (this.durability > 0)
        {
            if (isQuestItem)
                Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
            else
                Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
        }
        else
        {
            Console.WriteLine("The {0} has been broken.", this.name);
        }
    }

    ///<summary> public method Break() </summary>
    public void Break()
    {
        this.durability--;
        if (this.durability > 0)
        {
            Console.WriteLine($"You hit the {this.name}. It cracks.");
        }
        else if (this.durability == 0)
        {
            Console.WriteLine($"You smash the {this.name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {this.name} is already broken.");
        }
    }
}

///<summary> class Key </summary>
public class Key : Base, ICollectable
{
    ///<summary> public bool isCollected </summary>
    public bool isCollected { get; set; }

    ///<summary> public constructor </summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    ///<summary> public method Collect() </summary>
    public void Collect()
    {
        if (this.isCollected)
        {
            Console.WriteLine("You have already picked up the {0}.", this.name);
        }
        else
        {
            this.isCollected = true;
            Console.WriteLine("You pick up the {0}.", this.name);
        }
    }
}

///<summary> class RoomObjects </summary>
public class RoomObjects
{
    ///<summary> public static void IterateAction </summary>
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base item in roomObjects)
        {
            if (item is IInteractive && type == typeof(IInteractive))
            {
                IInteractive iItem = (IInteractive)item;
                iItem.Interact();
            }
            if (item is IBreakable && type == typeof(IBreakable))
            {
                IBreakable iItem = (IBreakable)item;
                iItem.Break();
            }
            if (item is ICollectable && type == typeof(ICollectable))
            {
                ICollectable iItem = (ICollectable)item;
                iItem.Collect();
            }
        }
    }
}
