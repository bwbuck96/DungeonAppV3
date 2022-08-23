using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerClassLibrary;

namespace DungeonAppV3
{
    public class Program
    {
        public static Player currentPlayer = new Player();
        static void Main(string[] args)
        {
            Start();
        }

        static void Start() { 
            Console.WriteLine("Welcome to The Dungeon");
            Console.Clear();
            Console.WriteLine($"You awaken to the feeling of cold, damp stone pressed against your face.\n\nYou are plagued with convenient amnesia and don't recall where you're from, how you got here, \nor even why you would be sleeping on the floor in the first place!\n" +
                    $"Suddenly, a foreign thought pops into your head, demanding answers of the very nature of your being!");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("What is your name?");
            Console.ForegroundColor = ConsoleColor.White;
            currentPlayer.Name = Console.ReadLine();

            if (currentPlayer.Name == "")
            {
                currentPlayer.Name = "Rork";
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Ah, {currentPlayer.Name}, of course...");
              

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Ah, {currentPlayer.Name}, of course...");
                Console.ReadKey();
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Gathering your wits, you notice this room is empty except for a small pool of water (that you had recently been napping in), and a door opposite you.\n\nWhat do you do?\n" +
                "1) Open the door.\n" +
                "2) Look at the puddle.\n" +
                "3) Twiddle your thumbs.\n" +
                "4) Go back to sleep.");
            Console.ForegroundColor = ConsoleColor.White;
            string playerAction = Console.ReadLine();
            bool menuOpen = true;
            do
            {
            switch (playerAction)
            {
                case "1":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You open the door, and see a yawning void ahead of you. Good thing you're not afraid of the dark, right?");

                        menuOpen = false;
                    break;
                case "2":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You stare into the puddle, thinking justhow nice it would be to go for a swim.");
                        Console.ReadKey();
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Whoa nelly, how about you try that again?");
                    break;

            }
            } while (menuOpen);

        }

    }
   
}
