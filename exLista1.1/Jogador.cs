using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exLista1._1
{
    public class Jogador
    {
        public int forca, ataque, defesa, velocidade;
        public string name;
        public float dinheiro;

        public Jogador(int forca, int ataque, int defesa, int velocidade, string name, float dinheiro)
        {
            this.forca = forca;
            this.ataque = ataque;
            this.defesa = defesa;
            this.velocidade = velocidade;
            this.name = name;
            this.dinheiro = dinheiro;
        }

        public void Atacar()
        {
            Console.WriteLine(name + " Atacou! ");
        }

        public void Defender()
        {
            Console.WriteLine(name + " Defendeu!");
        }


    }


}

