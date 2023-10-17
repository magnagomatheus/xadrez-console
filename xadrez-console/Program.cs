using System;
using System.Globalization;
using tabuleiro;
using xadrez;
using xadrez_console.xadrez;

namespace xadrez_console {
    class Program {
        static void Main() {

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);


            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();

        }
    }
}