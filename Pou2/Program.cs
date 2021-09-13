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

            Console.WriteLine("What do you want to do with your pet? \n");

            while (tamagotchi.GetAlive())
            {
                Console.WriteLine("--Teach,   Feed,   Greet,  Do nothing, Show health--");

                choice = Console.ReadLine().ToLower();

                if (choice == "teach")
                {
                    Console.WriteLine($"What word or sentence do you want to teach {tamagotchi.name}?");
                    tamagotchi.Teach();
                    tamagotchi.Tick();
                    Console.Clear();
                }

                if (choice == "feed")
                {
                    tamagotchi.Tick();
                    tamagotchi.Feed();
                    Console.WriteLine($"You feed {tamagotchi.name} with food.");
                    tamagotchi.PrintStats();
                    Console.ReadLine();
                    Console.Clear();
                }



            }

            Console.WriteLine($"Oh my god you killed {tamagotchi.name} wtf");


            Console.ReadLine();
        }
    }
}
