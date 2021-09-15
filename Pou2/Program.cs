using System;

namespace Pou2
{
    class Program
    {
        static void Main(string[] args)
        {

            Character tamagotchi = new Character();

            string choice;

            Console.WriteLine("Welcome to Pou 2 \nPress Enter to continue...");

            Console.ReadLine();


            Console.WriteLine("Name your new digital pet:");

            tamagotchi.name = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("What do you want to do?\n");

            while (tamagotchi.GetAlive())
            {
                Console.WriteLine("--Teach,   Feed,   Greet,  Do nothing.");
                tamagotchi.PrintStats();
                Console.WriteLine("\n");

                choice = Console.ReadLine().ToLower();

                if (choice == "teach")
                {
                    Console.Clear();
                    Console.WriteLine($"What word or sentence do you want to teach {tamagotchi.name}?");
                    tamagotchi.Teach();
                    tamagotchi.Tick();
                    Console.Clear();
                }

                if (choice == "feed")
                {
                    Console.Clear();
                    tamagotchi.Tick();
                    tamagotchi.Feed();
                    Console.WriteLine($"You feed {tamagotchi.name} with food.\nPress enter to continue.");
                    Console.ReadLine();
                    Console.Clear();
                }

                if (choice == "greet")
                {
                    Console.Clear();
                    tamagotchi.Hi();
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                    tamagotchi.Tick();
                    Console.Clear();
                }

                if (choice == "do nothing" || choice == "dn")
                {
                    Console.Clear();
                    Console.WriteLine("Time passes...\nPress enter to continue.");
                    tamagotchi.Tick();
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                }






            }

            Console.WriteLine($"Oh my god you killed {tamagotchi.name} wtf");


            Console.ReadLine();
        }
    }
}
