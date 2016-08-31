using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exLista1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador[] jogadores = new Jogador[3];
            jogadores[0] = new Jogador(100, 100, 100, 100, "Kenny", 0);
            jogadores[1] = new Jogador(90, 100, 80, 75, "Kyle", 1000);
            jogadores[2] = new Jogador(97, 100, 87, 100, "Stan", 500);

            Console.WriteLine(" Total de jogadores: " + jogadores.Length);

            Inimigo[] inimigos = new Inimigo[3];
            inimigos[0] = new Inimigo(100, 100, 100, 100, "Cartman", 1000);
            inimigos[1] = new Inimigo(87, 78, 89, 70, "Butters", 890);
            inimigos[2] = new Inimigo(67, 59, 90, 60, "Token", 400);

            Console.WriteLine(" Total de inimigos: " + inimigos.Length);

            Console.WriteLine(" Media da força dos jogadores: " + RetornaMForca(jogadores));
            Console.WriteLine(" Media da força dos inimigos: " + RetornaMForca(inimigos));
            Console.WriteLine(" Media de ataque dos jogadores:" + RetornaMAtaque(jogadores));
            Console.WriteLine("Media ataque dos jogadores:" + RetornaAtaque(inimigos));
            Console.WriteLine("Media velocidade dos jogadores:" + RetornaVelocidadeJ(jogadores));
            Console.WriteLine("Media de velocidade dos inimigos" + RetornaVelocidadeI(inimigos) );
            Console.WriteLine("Soma de dinheiro dos jogadores" + RetornaDinheiroJ(jogadores));
            Console.WriteLine("Soma de dinheiro dos inimigos" + RetornaDinheiroI(inimigos));
            Console.WriteLine("Maior media de ataque é dos :" + MaiorAtaque(jogadores, inimigos));
            Console.WriteLine("Maior media de defesa é dos" + MaiorDefesa ( jogadores, inimigos));
            Console.WriteLine("Maior media de velocidade é dos:" + MaiorVelocidade(jogadores,inimigos));
      

            Console.ReadLine();
        }

        static float RetornaMForca(Jogador[] jogadores)
        {
            float media = 0;

            for (int i = 0; i < jogadores.Length; i++)
            {
                media += jogadores[i].forca;
            }

            media /= jogadores.Length;
            return media;
        }

        static float RetornaMForca(Inimigo[] inimigos)
        {
            float media = 0;
            int contador = 0;
            foreach (Inimigo inimigo in inimigos)
            {
                media += inimigo.forca;
                contador++;
            }

            return media / contador;
        }

        static float RetornaMAtaque(Jogador[] jogadores)
        {
            float media = 0;
            for (int i = 0; i < jogadores.Length; i++)
            {
                media += jogadores[i].ataque;

            }

            return media / jogadores.Length;
        }

        static float RetornaAtaque(Inimigo[] inimigos)
        {
            float media = 0;
            for (int i = 0; i < inimigos.Length; i++)
            {
                media += inimigos[i].ataque;

            }
            return media / inimigos.Length;
        }

        static float RetornaVelocidadeJ(Jogador[] jogadores)
        {
            float media = 0;
            for (int i = 0; i < jogadores.Length; i++)
            {
                media += jogadores[i].velocidade;
            }
            return media / jogadores.Length;
        }

        static float RetornaVelocidadeI(Inimigo[] inimigos)
        {
            float media = 0;
            for (int i = 0; i < inimigos.Length; i++)
            {
                media += inimigos[i].velocidade;
            }
            return media / inimigos.Length;
        }

        static float RetornaDinheiroJ(Jogador[] jogadores)
        {
            float total = 0;
            for (int i = 0; i < jogadores.Length; i++)
            {
                total += jogadores[i].dinheiro;

            }
            return total;
        }

        static float RetornaDinheiroI(Inimigo[] inimigos)
        {
            float total = 0;
            for (int i = 0; i < inimigos.Length; i++)

            {
                total += inimigos[i].dinheiro;
            }
            return total;
        }

        static float RetornaDefesaJ(Jogador[] jogadores)
        {
            float media = 0;
            for (int i = 0; i < jogadores.Length; i++)
            {
                media += jogadores[i].defesa;
            }
            return media / jogadores.Length;
        }

        static float RetornaDefesaI(Inimigo[] inimigos)
        {
            float media = 0;
            for (int i = 0; i < inimigos.Length; i++)
            {
                media += inimigos[i].defesa;
            }
            return media / inimigos.Length;
        }



        static string MaiorAtaque (Jogador[] jogadores, Inimigo [] inimigos)
        {
            float ataqueInimigo = RetornaAtaque(inimigos);
            float ataqueJogador = RetornaMAtaque(jogadores);
            
            if ( ataqueInimigo > ataqueJogador)
            {
                return "Inimigo";
            }else
            {
                return "Jogador";
            }
            return "Iguais";
        }

        static string MaiorDefesa(Jogador[] jogadores, Inimigo[] inimigos)
        {
            float defesaInimigo = RetornaDefesaI(inimigos);
            float defesaJogador = RetornaDefesaJ(jogadores);

            if (defesaInimigo > defesaJogador)
            {
                return "Inimigo";
            }
            else
            {
                return "Jogador";
            }
            return "Iguais";
        }
        static string MaiorVelocidade(Jogador[] jogadores, Inimigo[] inimigos)
        {
            float velInimigo = RetornaVelocidadeI(inimigos);
            float velJogador = RetornaVelocidadeJ(jogadores);

            if (velInimigo > velJogador)
            {
                return "Inimigo";
            }
            else
            {
                return "Jogador";
            }
            return "Iguais";
        }
    }
}
