using System;

/// <summary> enum modifier </summary>
public enum Modifier
{
        /// <summary> weak </summary>
        Weak,

        /// <summary> base </summary>
        Base,

        /// <summary> strong </summary>
        Strong
}

/// <summary> delegate modifier </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary> hp args </summary>
public class CurrentHPArgs : EventArgs
{
        /// <summary> current hp </summary>
        public readonly float currentHp;

        /// <summary> constructor </summary>
        /// <param name="newHp"> </param>
        public CurrentHPArgs(float newHp)
        {
                currentHp = newHp;
        }
}

/// <summary> class player </summary>
public class Player
{
        /// <summary> event </summary>
        public event EventHandler<CurrentHPArgs> HPCheck;

        /// <summary> status </summary>
        private string status;

        /// <summary> name props </summary>
        private string name;

        /// <summary> maxHP props </summary>
        private float maxHp = 100f;

        /// <summary> hp props </summary>
        private float hp;

        private void CheckStatus(object sender, CurrentHPArgs e)
        {
                if (e.currentHp == maxHp)
                        status = $"{name} is in perfect health!";
                else if (e.currentHp >= maxHp / 2 && e.currentHp < maxHp)
                        status = $"{name} is doing well!";
                else if (e.currentHp >= maxHp / 4 && e.currentHp < maxHp / 2)
                        status = $"{name} isn't doing too great...";
                else if (e.currentHp > 0 && e.currentHp < maxHp / 2)
                        status = $"{name} needs help!";
                else status = $"{name} is knocked out!";

                Console.WriteLine(status);
        }

        /// <summary> apply modifier </summary>
        /// <param name="baseValue"> </param>
        /// <param name="modifier"> </param>
        /// <returns> </returns>
        public float ApplyModifier(float baseValue, Modifier modifier)
        {
                if (modifier is Modifier.Weak) return (baseValue / 2);
                else if (modifier is Modifier.Base) return baseValue;
                else return 1.5f * baseValue;
        }

        /// <summary> take damage </summary>
        /// <param name="damage"> </param>
        public void TakeDamage(float damage)
        {
                if (damage < 0) damage = 0;
                float newHealthVal = hp - damage;
                Console.WriteLine($"{name} takes {damage} damage!");
                ValidateHP(newHealthVal);
        }

        /// <summary> set new health </summary>
        /// <param name="newHealthVal"> </param>
        public void ValidateHP(float newHealthVal)
        {
                if (newHealthVal < 0) newHealthVal = 0;
                else if (newHealthVal > maxHp) newHealthVal = maxHp;
                hp = newHealthVal;
                // HPCheck?.Invoke(this, new CurrentHPArgs(hp));
                OnCheckStatus(new CurrentHPArgs(hp));
        }

        /// <summary> heal damage </summary>
        /// <param name="heal"> </param>
        public void HealDamage(float heal)
        {
                if (heal < 0) heal = 0;

                float newHealthVal = hp + heal;

                Console.WriteLine($"{name} heals {heal} HP!");
                ValidateHP(newHealthVal);
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
                status = $"{name} is ready to go!";

                HPCheck += CheckStatus;
        }

        /// <summary> print health </summary>
        public void PrintHealth()
        {
                Console.WriteLine($"{name} has {hp} / {maxHp} health");
        }

        /// <summary> event callback </summary>
        public void OnCheckStatus(CurrentHPArgs currentHp)
        {
                if (currentHp.currentHp <= maxHp / 4) HPCheck += HPValueWarning;
                HPCheck.Invoke(this, currentHp);
                HPCheck -= HPValueWarning;
        }

        /// <summary> warning event </summary>
        /// <param name="sender"> </param>
        /// <param name="e"> </param>
        private void HPValueWarning(object sender, CurrentHPArgs e)
        {
                if (e.currentHp == 0)
                {
                        status = $"Health has reached zero!";
                }
                else
                {
                        status = "Health is low!";
                }
                Console.WriteLine(status);
        }
}