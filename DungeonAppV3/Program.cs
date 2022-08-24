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
        //public static bool mainLoop = true;
        static void Main(string[] args)
        {
            Start();
            //Encounters.Tutorial();
            //while (mainLoop)
            //{
            //    Encounters.RandomEncounter();
            //}

        }

        static void Start()
        {
            Console.WriteLine("Welcome to The Dungeon");
            Console.ReadKey(true);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"You awaken to the feeling of cold, damp stone pressed against your face.\n\nYou are plagued with convenient amnesia\n");
            Console.ReadKey(true);
            Console.WriteLine($"Where are you?\n");
            Console.ReadKey(true);
            Console.WriteLine("How did you get here?\n");
            Console.ReadKey(true);
            Console.WriteLine("Do you normally take naps on the floor?!\n");
            Console.ReadKey(true);
            Console.WriteLine($"Suddenly, a foreign thought pops into your head, demanding answers of the very nature of your being...");
            Console.ReadKey(true);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("What is your name?");
            Console.ForegroundColor = ConsoleColor.White;
            currentPlayer.Name = Console.ReadLine();

            if (currentPlayer.Name == "")
            {
                currentPlayer.Name = "Rork";
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Ah, {currentPlayer.Name}, of course...");
                Console.ReadKey(true);


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Ah, {currentPlayer.Name}, of course...");
                Console.ReadKey(true);
            }
            bool menuOpen = true;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Gathering your wits, you notice this room is empty except for a small pool of water (that you had recently been napping in), and a door opposite you.\n\nWhat do you do?\n" +
                "1) Open the door\n" +
                "2) Look at the puddle\n" +
                "3) Examine yourself\n" +
                "4) Go back to sleep");
                Console.ForegroundColor = ConsoleColor.White;
                string playerAction = Console.ReadLine();

                switch (playerAction)
                {
                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You open the door, and see a yawning void ahead of you. Good thing you're not afraid of the dark...");
                        Console.ReadKey(true);
                        Console.WriteLine("In the shadowy distance, you can see the occasional flicker of a torch.");

                        menuOpen = false;
                        break;
                    case "2":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("You stare into the puddle, thinking just how nice it would be to go for a swim.");
                        Console.ReadKey();
                        break;
                    case "3":
                        //Checking player information (currentPlayer.ToString() using the overridden ToString method we made in Player.cs
                        Console.Clear();
                        Console.WriteLine(currentPlayer.ToString());
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Now that just won't do, {currentPlayer.Name}!\nIf you really want to sleep that much, why don't you take a dirt nap!");
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Clear();
                        
                        Console.WriteLine($"\n\n\nYou have died....");
                        Console.ReadKey();
                        menuOpen = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Whoa nelly, how about you try that again?");
                        break;

                }
            } while (menuOpen);

            Console.WriteLine("You have reached the end...congrats!");

        }

    }

}
