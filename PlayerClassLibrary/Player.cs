using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerClassLibrary
{

    public class Character
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int Damage { get; set; }


        public Character()
        {

        }
        public Character(string name, int maxHealth, int currentHealth, int damage)
        {
            Name = name;
            MaxHealth = maxHealth;
            CurrentHealth = currentHealth;
            Damage = damage;
            
        }
    }

    public class Player : Character
    {

        //public string Name;
        //public int Health = 10;
        //public int Damage = 1;
        public int Coins = 0;
        public int ArmorValue = 0;
        public int PotionCount = 3;
        public int WeaponValue = 1;

        public Player()
        {

        }
        public Player(string name, int coins, int maxHealth, int currentHealth, int damage, int armor, int potionCount, int weaponValue) : base(name, currentHealth, maxHealth, damage)
        {
            Coins = coins;
            ArmorValue = armor;
            PotionCount = potionCount;
            WeaponValue = weaponValue;
        }


        public override string ToString()
        {
            return string.Format($" @==[-----> CHARACTER MENU <-----]==@ \n\n{Name}\nHealth: {CurrentHealth} of {MaxHealth}\nCoins: {Coins}\nPotions: {PotionCount}");
        }
    }

}
