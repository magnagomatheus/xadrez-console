using System;
using System.Globalization;
using tabuleiro;


namespace xadrez_console {
    class Program {
        static void Main() {

            Posicao P;
            Tabuleiro tab = new Tabuleiro(8, 8);

            P = new Posicao(3, 4);

            Console.WriteLine($"Posição: {P}");

        }
    }
}