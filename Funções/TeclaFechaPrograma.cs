using System;

namespace LearningProject
{
    class TeclaFechaPrograma
    {
        static void Main(string[] args)
        {
            EsperarTeclaParaFecharPrograma();
        
            Console.ReadKey(true);
        }

        static void EsperarTeclaParaFecharPrograma()
        {
            Console.WriteLine("Aperte uma tecla para fechar o programa. ");
            Console.ReadKey(true);
            Console.WriteLine("Tem certeza?");

            ConsoleKey teclaQueOUsuarioApertou = Console.ReadKey(true).Key;

            if (teclaQueOUsuarioApertou == ConsoleKey.S)
            {
                Environment.Exit(0);
            }

            else if (teclaQueOUsuarioApertou == ConsoleKey.N)
            {
                Console.WriteLine("Obrigada e até breve. ");
            }
        }
    }
}
