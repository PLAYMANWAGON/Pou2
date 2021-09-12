using System;

namespace Pou2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pou 2 \nPress Enter to continue...");

            Console.ReadLine();

            Character tamagotchi = new Character();

            Console.WriteLine("Name your new digital pet:");

            tamagotchi.name = Console.ReadLine();




            Console.ReadLine();
        }
    }
}
