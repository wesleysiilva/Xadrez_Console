using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console {
   class Program {
      static void Main(string[] args) {

         #region Teste1
         /*
         try {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 9));

            Tela.imprimirTabuleiro(tab);
         }
         catch(TabuleiroException e) {
            Console.WriteLine(e.Message);
         }
         catch(Exception e) {
            Console.WriteLine(e.Message);
         }
         */
         #endregion

         #region

         PosicaoXadrez pos = new PosicaoXadrez('c', 7);

         Console.WriteLine(pos);
         Console.WriteLine(pos.toPosicao());

         #endregion

         Console.ReadLine();
      }
   }
}
