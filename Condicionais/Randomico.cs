using System;

namespace LearningProject
{
    class Randomico
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();
            int numeros;

            numeros = numberGen.Next(1, 10);
            Console.WriteLine(numeros);

            if (numeros > 5)
                Console.WriteLine("O número que gerou é maior que 5. ");

            else if (numeros < 5)
                Console.WriteLine("O número é menor que 5. ");

            else 
                Console.WriteLine("O número gerado é igual a 5. ");

            Console.ReadKey();
        }
    }
}
