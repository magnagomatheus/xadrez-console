﻿using System;
using System.Globalization;
using tabuleiro;
using xadrez;
using xadrez_console.xadrez;

namespace xadrez_console {
    class Program {
        static void Main() {

            try {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                Tela.imprimirTabuleiro(tab);
            }

            catch (TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}