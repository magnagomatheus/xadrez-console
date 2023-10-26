using System;
using System.Globalization;
using tabuleiro;
using xadrez;
using xadrez_console.xadrez;

namespace xadrez_console {
    class Program {
        static void Main() {

            try {

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada) {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();

                    Console.Write("Digite a posição de origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.WriteLine("Posição destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }

                Tela.imprimirTabuleiro(partida.tab);
            
            }

            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}