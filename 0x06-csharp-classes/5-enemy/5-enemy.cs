using System;

namespace Enemies
{
    ///<summary>Public class that defines a Zombie</summary>
    class Zombie
    {
        private int _health;

        ///<summary>Public constructor that defines a Zombies health</summary>
        public Zombie()
        {
            _health = 0;
        }

        ///<summary>Public constructor that throws ArgumentException if health if less than 0</summary>
        public Zombie(int value)
        {
            _health = value;
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }

        private string _name = "(No name)";

        ///<summary>Public property that gets and sets name</summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        ///<summary>Public method that returns the value of health of the Zombie object</summary>
        public int GetHealth()
        {
            return _health;
        }

        ///<summary>public .toString() override that prints the Zombie object’s attributes to stdout</summary>
        public override string ToString()
        {
            return "Zombie Name: " + _name + " / " + "Total Health: " + _health;
        }
    }
}
