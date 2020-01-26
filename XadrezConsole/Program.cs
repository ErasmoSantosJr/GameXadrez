using System;
using Tabuleiro;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiros tabuleiro = new Tabuleiros(8,8);

            Tela.imprimirTabuleiro(tabuleiro);
            Console.WriteLine();
        }
    }
}
