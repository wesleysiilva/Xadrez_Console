﻿using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console {
   class Program {
      static void Main(string[] args) {

         #region Teste1

         try {
            PartidaDeXadrez partida = new PartidaDeXadrez();

            while (!partida.terminada) {

               Console.Clear();
               Tela.imprimirTabuleiro(partida.tab);

               Console.WriteLine();
               Console.Write("Origem: ");
               Posicao origem = Tela.lerPosicaoXadrez( ).toPosicao();
               Console.Write("Destino: ");
               Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

               partida.executaMovimento(origem, destino);

            }
            
         }
         catch (TabuleiroException e) {
            Console.WriteLine(e.Message);
         }
         catch (Exception e) {
            Console.WriteLine(e.Message);
         }

         #endregion

         #region Teste2
         /*
         PosicaoXadrez pos = new PosicaoXadrez('c', 7);

         Console.WriteLine(pos);
         Console.WriteLine(pos.toPosicao());
         */
         #endregion

         Console.ReadLine();
      }
   }
}
