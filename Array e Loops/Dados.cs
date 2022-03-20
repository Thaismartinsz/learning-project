using System;

namespace LearningProject
{
    class Dados
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int Dado1 = 1;
            int Dado2 = 4;
            int Dado3 = 2;
            int attempts = 0;

            Console.WriteLine("Pressione enter para jogar os 3 dados. ");

            Console.ReadKey();

            while (!(Dado1 == Dado2 && Dado1 == Dado3 && Dado2 == Dado3))
            {
                Console.ReadKey();
                Dado1 = numberGen.Next(1, 7);
                Dado2 = numberGen.Next(1, 7);
                Dado3 = numberGen.Next(1, 7);
                Console.WriteLine("Dado 1: " + Dado1);
                Console.WriteLine("Dado 2: " + Dado2);
                Console.WriteLine("Dado 3: " + Dado3);
                Console.WriteLine();
                attempts++;
            }

            Console.WriteLine("Foram " + attempts + " tentativas até cair igual.");

            Console.ReadKey();   
        }
    }
}
