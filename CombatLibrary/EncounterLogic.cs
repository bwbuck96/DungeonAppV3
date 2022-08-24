using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CombatLibrary;

namespace CombatLibrary
{
    class EncounterLogic
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

            public static void BasicFightEncounter()
            {
                Console.WriteLine("You turn the corner and before you is a hulking beast!");
                Console.ReadKey();
                Combat(true, "", 0, 0);
            }
            //Encounter Tools

            public static void RandomEncounter()
            {
                switch (rand.Next(0, 1))
                {
                    case 0:
                        BasicFightEncounter();
                        break;
                    default:
                        break;
                }
            }

        }
    }
