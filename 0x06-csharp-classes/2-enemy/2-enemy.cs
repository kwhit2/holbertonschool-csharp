using System;

namespace Enemies
{
    ///<summary>Public class that defines a Zombie</summary>
    class Zombie
    {
        public int health;

        ///<summary>Public constructor that defines a Zombies health</summary>
        public Zombie()
        {
            health = 0;
        }

        ///<summary>Public constructor that throws ArgumentException if health if less than 0</summary>
        public Zombie(int value)
        {
            health = value;
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
    }
}
