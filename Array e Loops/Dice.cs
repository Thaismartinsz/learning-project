using System;

namespace LearningProject
{
    class Dice
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int roll = 0;
            int attempts = 0;

            Console.WriteLine("press enter to roll the die.");

            while (roll != 6)
            {
                Console.ReadKey();

                roll = numberGen.Next(1, 7);
                Console.WriteLine("You Rolled: " + roll);
                attempts++;
            }

            Console.WriteLine("it took you" + attempts + " attempts to roll a six");

            Console.ReadKey();
        }
    }
}
