using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerClassLibrary;
using DungeonAppV3;

namespace CombatLibrary
{
    public class Encounters
    {

        static Random rand = new Random();
        //Encounter Generic

        //Encounters
        public static void Tutorial()
        {
            Console.WriteLine("You throw open the door, charging toward your captor! You instinctively grab a rusty metal sword off your hip.");
            Console.WriteLine("\n\nHe turns...");
            Console.ReadKey();
            Combat(false, "Human Rouge", 1, 4);
        }
        //Encounter Tools
        public static void Combat(bool random, string name, int power, int health)
        {
            bool menuOpen = true;
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0 && menuOpen)
            {
                Console.WriteLine("===================");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("|   (R)un  (H)eal   |");
                Console.WriteLine("===================");
                Console.WriteLine("Potions: " + Program.currentPlayer.PotionCount + " Health: " + Program.currentPlayer.Health); string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "a":
                        //Attack

                        Console.WriteLine($"{Program.currentPlayer.Name} swings their blade valiatly!");

                        int damage = p - Program.currentPlayer.ArmorValue; //Damage dealt to player
                        if (damage < 0)
                        {
                            damage = 0;
                        }
                        int attack = rand.Next(0, Program.currentPlayer.WeaponValue) + rand.Next(1, 4); //Damage dealt to monster


                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{n} takes {attack} damage!");
                        Console.WriteLine($"{Program.currentPlayer.Name} takes {damage} damage!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Program.currentPlayer.Health -= damage;
                        h -= attack;
                        break;
                    case "d":
                        //Defend
                        Console.WriteLine($"{Program.currentPlayer.Name} prepares to defend!");

                        damage = (p / 4) - Program.currentPlayer.ArmorValue; //Damage dealt to player
                        if (damage < 0)
                        {
                            damage = 0;
                        }
                        attack = rand.Next(0, Program.currentPlayer.WeaponValue) + rand.Next(1, 4); //Damage dealt to monster


                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{n} takes {attack} damage!");
                        Console.WriteLine($"{Program.currentPlayer.Name} takes {damage} damage!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Program.currentPlayer.Health -= damage;
                        h -= attack;
                        break;

                    case "r":
                        //Run
                        if (rand.Next(0, 2) == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"As you run away from the {n}, it knocks you to the ground!");
                            Console.ForegroundColor = ConsoleColor.Red;
                            damage = p - Program.currentPlayer.ArmorValue;
                            if (damage < 0)
                            {
                                damage = 0;
                            }
                            Console.WriteLine($"{ Program.currentPlayer.Name} takes {damage} damage and fails to run away!");
                            Program.currentPlayer.Health -= damage;
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine($"You dip, dodge, and weave your way away from the {n} and get away safe!");
                            Console.ReadKey();
                            menuOpen = false;
                        }
                        break;
                    case "h":
                        //Heal
                        if (Program.currentPlayer.PotionCount == 0)
                        {
                            Console.WriteLine($"You desperately reach for a potion, but find nothing there!");
                            Console.WriteLine($"The {n} cackles as it slashes your chest!");
                            Console.ForegroundColor = ConsoleColor.Red;
                            damage = p - Program.currentPlayer.ArmorValue;
                            if (damage < 0)
                            {
                                damage = 0;
                            }
                            Console.WriteLine($"{Program.currentPlayer.Name} takes {damage} damage!");
                            Console.ForegroundColor = ConsoleColor.White;
                            Program.currentPlayer.Health -= damage;
                        }
                        else
                        {
                            Console.WriteLine("You reach into your bag and grab a glowing red flask.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            int potionV = 5;
                            Console.WriteLine($"{Program.currentPlayer.Name} heals for {potionV} health");
                            Console.ForegroundColor = ConsoleColor.White;
                            Program.currentPlayer.Health += potionV;
                        }
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
            }
            int c = rand.Next(10, 51);
            Console.WriteLine("As you stand victorious over the " + n + ", its body dissolves into " + c + " gold coins!");
        }
        public string GetName()
        {
            switch (rand.Next(0, 10))
            {
                case 0:
                    return "Skeleton";
                case 1:
                    return "Zombie";
                case 2:
                    return "Cultist";
                case 3:
                    return "Bat";
                case 4:
                    return "Bandit";
                case 5:
                    return "Rock Worm";
                case 6:
                    return "Phase Spider";
                case 7:
                    return "Giant Ant";
                case 8:
                    return "Wraith";
                case 9:
                    return "Horned Rabbit";
                case 10:
                    return "Goblin";
            }
            return "Human";
        }
    }
}
