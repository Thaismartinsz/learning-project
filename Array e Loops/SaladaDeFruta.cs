using System;

namespace SaladaDeFruta
{
    class SaladaDeFruta
    {
        static void Main(string[] args)
        {
            string[] fruta = new string[5];
            
            Console.WriteLine("Escolha 5 frutas: ");

            for (int i = 0; i < fruta.Length; i++)
            {
                fruta[i] = Console.ReadLine();
            }

            Console.WriteLine("A lista das suas frutas: ");

            for (int i = 0; i < fruta.Length; i++)
            {
                Console.WriteLine("A fruta " + (i+1) + " é "+ fruta[i]);
            }

            Console.ReadKey();
        }
    }
}
