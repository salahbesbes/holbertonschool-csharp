﻿using System;


namespace Enemies
{

    class Zombie
    {
        private int health;
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public Zombie()
        {
            health = 0;
            name = "(No name)";

        }

        public Zombie(int value)
        {
            if (value < 0) throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
            name = "(No name)";
        }

        public int GetHealth()
        {
            return health;
        }

        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
