using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerClassLibrary;

namespace CombatLibrary
{
    public class Combat
    {


        public static void DoAttack(Player attacker, Character defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);//Upper bound is EXCLUSIVE
            System.Threading.Thread.Sleep(30);
            if (diceRoll <= ((attacker.Damage + attacker.WeaponValue) - (defender.Block)))
            {
                int damageDealt = attacker.CalcDamage();

                defender.CurrentHealth -= damageDealt;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }
        }

        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);

            if (monster.Health > 0)
            {
                DoAttack(monster, player);
            }
        }
    }
}


