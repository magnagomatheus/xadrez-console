using System;


namespace tabuleiro
{
    internal class Posicao
    {

        public int linha { get; set; }
        public int coluna { get; set; }

        public Posicao(int l, int c) {
            this.linha = l;
            this.coluna = c;
        }


        public override string ToString()
        {
            return $"{linha}, {coluna}";
        }
    }
}
