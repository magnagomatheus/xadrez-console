using System;
using System.Globalization;
using tabuleiro;

namespace xadrez_console {
    class Program {
        static void Main() {

            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine($"Posição: {P}");

        }
    }
}