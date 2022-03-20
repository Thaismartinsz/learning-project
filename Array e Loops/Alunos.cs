using LanguageExt.UnitsOfMeasure;
using System;

namespace LearningProject
{
    class Alunos
    {
        static void Main(string[] args)
        {           
            Console.Write("Quantos alunos tem na sala? ");
            string[] alunos = new string[int.Parse(Console.ReadLine())];

            Console.WriteLine("Coloque os nomes deles aqui: ");

            for (int i = 0; i < alunos.Length; i++)
            {
                alunos[i] = Console.ReadLine();
            }

            Console.WriteLine("\nAgora eles estão em ordem alfabetica: ");
            Array.Sort(alunos);

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine(alunos[i]);
            }

            Console.ReadKey();
        }
    }      
}
