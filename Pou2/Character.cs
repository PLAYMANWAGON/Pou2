using System;
using System.Collections.Generic;

namespace Pou2
{
    public class Character
    {
        private bool isAlive = true;

        public Random generator = new Random();

        private int hunger = 5;
        private int boredom = 5;

        private List<string> words = new List<string>()
        {
            "\"Swag.\"",
            "\"Soulja boy, tell em'.\"",
            "\"Stove.\"",
            "\"Rick n Morty.\"",
            "\"They came, they brought me the iPhone.\""

        };


        public string name;

        public void Feed()
        {
            if (hunger <= 1)
            {
                hunger = 0;

            }
            else
            {
                hunger = hunger - 2;
            }
        }

        public void Hi()
        {
            int index = generator.Next(words.Count);

            Console.WriteLine($"{name} says {words[index]}");

            ReduceBoredom();

        }

        public void Teach()
        {
            words.Add(Console.ReadLine());

        }

        public void Tick()
        {
            hunger++;
            boredom++;

            if (hunger >= 10 || boredom >= 10)
            {
                isAlive = false;
            }
        }

        public void PrintStats()
        {
            //          IS DYING (NOT) ---------------------------------------------------------------
            Console.WriteLine($"Boredom: {boredom}      Hunger: {hunger}\n");

            if (hunger <= 3 && boredom <= 3)
            {
                Console.WriteLine($"{name} is doing great! It is euphoric and is stuffed!");
            }

            //          IT IS ALMOST DYING -------------------------------------------------------
            if (hunger <= 3 && 4 <= boredom && boredom <= 7)
            {
                Console.WriteLine($"{name} is doing fine. It is starving but is happy!");
            }

            if (hunger <= 3 && 8 <= boredom && boredom <= 10)
            {
                Console.WriteLine($"{name} is doing fine. It is well fed but is bored...");
            }

            if (4 <= hunger && hunger <= 7 && boredom <= 3)
            {
                Console.WriteLine($"{name} is doing fine. It is bored but is well fed!");
            }

            if (8 <= hunger && hunger <= 10 && boredom <= 3)
            {
                Console.WriteLine($"{name} is doing fine. It is having fun but is starving...");
            }

            if (8 <= hunger && hunger <= 10 && 4 <= boredom && boredom <= 7)
            {
                Console.WriteLine($"{name} is feeling average. It is having fun but is starving.");
            }

            if (4 <= hunger && hunger <= 7 && 8 <= boredom && boredom <= 10)
            {
                Console.WriteLine($"{name} is feeling average. It is bored but is well fed.");
            }

            //          EQUILIBRIUM-------------------------------------------------------------------
            if (4 <= hunger && hunger <= 7 && 4 <= boredom && boredom <= 7)
            {
                Console.WriteLine($"{name} is feeling average. It is having fun and is well fed.");
            }

            //          IS DYING-------------------------------------------------------------------------
            if (hunger > 7 && boredom > 7)
            {
                Console.WriteLine($"{name} is sad. It is starving and is bored...");
            }

        }

        public bool GetAlive()
        {
            return isAlive;

        }

        private void ReduceBoredom()
        {
            if (boredom <= 1)
            {
                boredom = 0;

            }
            else
            {
                boredom = boredom - 2;
            }

        }
    }

}