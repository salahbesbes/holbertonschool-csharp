using System;

/// <summary> class player </summary>
public class Player
{
        /// <summary> name props </summary>
        private string name;

        /// <summary> maxHP props </summary>
        private float maxHp = 100f;

        /// <summary> hp props </summary>
        private float hp;

        /// <summary> take damage </summary>
        /// <param name="damage"> </param>
        public void TakeDamage(float damage)
        {
                if (damage < 0) damage = 0;
                float newHealthVal = hp - damage;
                ValidateHP(newHealthVal);
                Console.WriteLine($"{name} takes {damage} damage!");
        }

        /// <summary> set new health </summary>
        /// <param name="newHealthVal"> </param>
        public void ValidateHP(float newHealthVal)
        {
                if (newHealthVal < 0) newHealthVal = 0;
                if (newHealthVal > maxHp) newHealthVal = maxHp;

                hp = newHealthVal;
        }

        /// <summary> heal damage </summary>
        /// <param name="heal"> </param>
        public void HealDamage(float heal)
        {
                if (heal < 0) heal = 0;
                float newHealthVal = hp + heal;
                ValidateHP(newHealthVal);

                Console.WriteLine($"{name} heals {heal} HP!");
        }

        /// <summary> delegate </summary>
        /// <param name="value"> </param>
        public delegate void CalculateHealth(float value);

        /// <summary> constructor </summary>
        /// <param name="name"> </param>
        /// <param name="maxHp"> </param>
        public Player(string name = "Player", float maxHp = 100f)
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