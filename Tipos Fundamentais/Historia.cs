using System;

namespace LearningProject
{
    class Historia
    {
        private const int V = 40;

        static void Main(string[] args)
        {
            Console.Title = "primeiros passos - conversa";
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Era uma vez... a meia noite, num lugar muito...");

            Console.ReadLine();

            Console.WriteLine("Haviam 3 pessoas, estavam com muito medo pois nesse lugar tinha...");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Que corria atras deles para tentar devora-los.");
            Console.ReadLine(); 
            Console.WriteLine("Tentando fugir, encontraram uma casa e conseguiram se esconder.");
            Console.WriteLine("FIM");

            Console.ReadKey();
        }
    }
}
