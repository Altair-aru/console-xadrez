using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {

              try
            {
                PartidaXadrez partida = new PartidaXadrez();        
                
                while (!partida.terminada)
                {
                    Console.Clear();

                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem:");

                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                    Console.Write("Destino:");

                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executarMovimento(origem, destino);
                }

               
            }
          
            catch (TabuleiroExceptions e)
            {
                Console.WriteLine(e.Message);
            }

              // PosicaoXadrez pos = new PosicaoXadrez('b', 2);

              //  Console.WriteLine(pos);

              //  Console.WriteLine(pos.toPosicao());

                Console.ReadLine();
         }
    }
}
