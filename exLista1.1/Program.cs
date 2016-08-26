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
            
            return media/jogadores.Length;
        }
    }
}
