using System;

namespace LearningProject            
{
    class Potencia
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos número legais você quer: ");

            int count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
