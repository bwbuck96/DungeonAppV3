using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerClassLibrary;

namespace MonsterClassLibrary
{
    public class Monster : Character
    {
        private int _minDamage;
        //Name
        //CurrentHealth
        //MaxHealth
        //Damage
        //Block
        public string Description { get; set; }
        public int MaxDamage { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {

                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        public Monster()
        {

        }
        public Monster(string name, int currentHealth, int maxHealth, int maxDamage, int minDamage, int block, string description, int damage) : base(name, maxHealth, currentHealth, damage, block)
        {
            MaxDamage = maxDamage;
            MaxHealth = maxHealth;
            MinDamage = minDamage;
            Description = description;
        }

        public override string ToString()
        {
            return string.Format($"\n\n@==[--------> MONSTER INSPECTION <--------]==@\n\n" +
                $"Health: {CurrentHealth} of {MaxHealth}\n" +
                $"");
           // return base.ToString(); 
        }

        public override int CalcDamage()
        {
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
       
        }

    }
}
