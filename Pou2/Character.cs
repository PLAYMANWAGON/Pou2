using System;
using System.Collections.Generic;

namespace Pou2
{
    public class Character
    {
        // public int generator = new Random();

        private int hunger;
        private int boredom;

        private List<string> words = new List<string>()
        {
            "Swag.",
            "Soulja boy, tell em'.",
            "Stove.",
            "Rick n Morty.",
            "They came, they brought me the iPhone."
        };

        private bool isAlive;

        public string name;

        public void Feed()
        {
            hunger--;
        }

        public void Hi()
        {


        }

        public void Teach()
        {

        }

        public void Tick()
        {
            hunger++;
            boredom++;

            if (hunger > 10 || boredom > 20)
            {
                isAlive = false;
            }
        }

        public void PrintStats()
        {

        }

        public void GetAlive()
        {

        }

        private void ReduceBoredom()
        {

        }

    }
}