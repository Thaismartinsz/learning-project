using System;

namespace LeraningProject 
{
    internal class Soma
    {
        static void Main(string[] args)
        {
            double num01;
            double num02; 
            double num03;

            Console.Write("Insira um numero: ");

            num01 = Convert.ToDouble( Console.ReadLine() );

            Console.Write ("Coloque o segundo numero ");
            num02 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Agora, o terceiro numero. ");
            num03 = Convert.ToDouble( Console.ReadLine());

            double result = (num01 + num02 + num03) /3; 
            Console.WriteLine("Esse é o resultado " + result);

            Console.ReadKey();
        }
    }
}