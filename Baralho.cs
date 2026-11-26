using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo21
{
    internal class Baralho : Carta
    {
        protected Carta[] cartas;
        protected int quantidadeDeCartas = 0;

        public Baralho() {

            this.constroiBaralho();

        }

        public void constroiBaralho()
        {
            quantidadeDeCartas = this.getNaipesPermitidos().Length * this.getValoresPermitidos().Length;
            cartas = new Carta[quantidadeDeCartas];

            int i = 0;
            foreach(string _naipe in this.getNaipesPermitidos())
            {
                foreach (string _valor in this.getValoresPermitidos())
                {
                    cartas[i++] = new Carta(_valor, _naipe);                     
                }
            }
        }

        public void embaralha()
        { 
            // Algoritmo de Fisher-Yates para geração de n números aleatórios
            Random rnd = new Random();
            int i = 0;

            Carta[] baralhoCopia = new Carta[this.quantidadeDeCartas];
            foreach (Carta carta in this.cartas)
                baralhoCopia[i++] = carta;

            Carta[] baralhoFinal = new Carta[this.quantidadeDeCartas];

            for (i = 0; i < this.quantidadeDeCartas; i++)
            {
                int indiceSorteado = rnd.Next(0, baralhoCopia.Length);
                Carta c = baralhoCopia[indiceSorteado];

                baralhoFinal[i] = c;

                Carta[] novoMonte = new Carta[baralhoCopia.Length - 1];
                int k = 0;
                for (int j = 0; j < baralhoCopia.Length; j++)
                {
                    if(j != indiceSorteado)
                    {
                        novoMonte[k++] = baralhoCopia[j];
                    }
                }

                baralhoCopia = novoMonte;
            }

            setCartas(baralhoFinal);
        }

        public void setCartas(Carta[] novoBaralho)
        {
            this.cartas = novoBaralho;
            //for(int i = 0; i < this.cartas.Length; i++)
                //this.cartas[i] = novoBaralho[i];
        }

        public virtual string mostraCartas()
        {
            string mensagem = "";
            for (int i = 0; i < this.cartas.Length; i++)
                mensagem += this.cartas[i].getValor()+
                    " de " 
                    + this.cartas[i].getNaipe() + "\n";

            return mensagem;
        }
    }
}
