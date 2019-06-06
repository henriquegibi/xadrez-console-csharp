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
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 1));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                tab.colocarPeca(new Rei(tab, Cor.Branca), new Posicao(0, 3));

                Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}