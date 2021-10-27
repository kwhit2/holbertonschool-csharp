using System;

/// <summary> class Player </summary>
public class Player
{
    /// <summary> public property name </summary>
    private string name { get; set; }

    /// <summary> public property maxHp </summary>
    private float maxHp { get; set; }

    /// <summary> public property hp </summary>
    private float hp { get; set; }

    /// <summary> public constructor Player </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.name = name;
        this.hp = this.maxHp;
    }

    /// <summary> public method PrintHealth() </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}
