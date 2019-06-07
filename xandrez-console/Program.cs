/* Obrigado por averiguar este Código.
 * Aceito receber sugestões e colaborações. Caso queira entrar en contato comigo, segue:
 * https://www.linkedin.com/in/henriquedepadua/
 * https://www.apinfo2.com/apinfo/inc/roteador.cfm?prof=552433&pcargo=%20Programador%20/%20Desenvolvedor%20&pkey=%20YFtkxtkFZKFZlFKk
 * Desde já, muito obrigado .*/

using System;
using tabuleiro;
using xadrez;

namespace xandrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);
                }

                Tela.imprimirTabuleiro(partida.tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}