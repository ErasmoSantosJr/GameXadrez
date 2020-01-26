using System;
using Tabuleiro;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiros tabuleiro = new Tabuleiros(8,8);

            Console.WriteLine("Tabuleiro " + tabuleiro);
            Console.WriteLine();
        }
    }
}
