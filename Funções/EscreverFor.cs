using System;

namespace LearningProject
{
    class EscreverFor
    {
        static void Main(string[] args)
        {
            string frase = "I love programing.";
            Console.WriteLine(frase);
    
            string[] palavras = frase.Split(' ');
            int totalPalavras = palavras.Length;

            EscreverForNoConsole(palavras);
          
            Console.WriteLine($"Essa frase tem {totalPalavras} palavras.");

            string fruta = "Banana";
            string[] saladaDeFruta = new string[] { "Banana", "Maçã", "Morango" };

            EscreverForNoConsole(saladaDeFruta);

            Console.ReadKey();
        }
   
        static void EscreverForNoConsole(string[] arrayDeString)
        {
            for (int i = 0; i < arrayDeString.Length; i++)
            {
                Console.WriteLine(arrayDeString[i]);
            }

            Console.WriteLine("Aleluia!");
        }
    }
}
