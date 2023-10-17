using System;


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

        public Peca peca(int li, int co) {
            return pecas[li, co];
        }

        public Peca peca(Posicao pos) {
            return pecas[pos.linha, pos.coluna];
        }

        public bool existePeca(Posicao pos) {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPeca(Peca p, Posicao pos) {
            if (!existePeca(pos) {
                pecas[pos.linha, pos.coluna] = p;
                p.posicao = pos;
            }
            else {
                throw new TabuleiroException("Já existe uma peça nessa posição!!");
            }
            
        }

        public bool posicaoValida(Posicao pos) {

            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas) {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos) {

            if (!posicaoValida(pos)) {
                throw new TabuleiroException("Posição inválida!");
            }

        }
    }
}
