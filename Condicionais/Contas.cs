using System;

namespace LearningProject
{
    class Contas
    {
        static void Main(string[] args)
        {
            int answer;

            Console.Write("15 + 2 + 7 + 5 = ");

            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 25)
            {
                Console.WriteLine("Correto! ");
            }
            else
            { 
                Console.WriteLine("Errou! ");
            }

            Console.Write("15 + 12 + 28 + 5 = ");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 60)
            {
                Console.WriteLine("Correto! ");
            }
            else
            {
                Console.WriteLine("Errou! ");
            }

            Console.Write("15 + 3 * 28 = ");
            answer = Convert.ToInt32(Console.ReadLine());

            if (answer == 99)
            {
                Console.WriteLine("Correto! ");
            }
            else
            {
                Console.WriteLine("Errou! ");
            }

            Console.ReadKey();
        }
    }
}
