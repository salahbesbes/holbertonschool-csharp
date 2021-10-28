using System;

/// <summary> class player </summary>
public class Player
{
        /// <summary> name props </summary>
        private string name { get; set; } = "Player";

        /// <summary> maxHP props </summary>
        private float maxHp { get; set; } = 100f;

        /// <summary> hp props </summary>
        private float hp { get; set; }

        /// <summary> constructor </summary>
        /// <param name="name"> </param>
        /// <param name="maxHp"> </param>
        public Player(string name, float maxHp)
        {
                if (maxHp <= 0)
                {
                        maxHp = 100f;
                        Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
                }
                this.name = name;
                this.maxHp = maxHp;
                hp = maxHp;
        }

        /// <summary> print health </summary>
        public void PrintHealth()
        {
                Console.WriteLine($"{name} has {hp} / {maxHp} health");
        }
}