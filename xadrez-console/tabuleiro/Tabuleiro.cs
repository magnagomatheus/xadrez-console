﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Tabuleiro
    {

        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int l, int c) {
            this.linhas = l;
            this.colunas = c;
            pecas = new Peca[linhas, colunas];
        }
    }
}
