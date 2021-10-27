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

    /// <summary> delegate CalculateHealth </summary>
    delegate void CalculateHealth(float health);

    /// <summary> public method TakeDamage() </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
        {
            damage = 0f;
            Console.WriteLine($"{this.name} takes 0 damage!");
        }
        else
        {
            Console.WriteLine($"{this.name} takes {damage} damage!");
        }
    }

    /// <summary> public method HealDamage() </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            heal = 0f;
            Console.WriteLine($"{this.name} heals 0 HP!");
        }
        else
        {
            Console.WriteLine($"{this.name} heals {heal} HP!");
        }
    }
}
