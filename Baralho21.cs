using System;

namespace Jogo21
{
    /// <summary>
    /// Baralho de 52 cartas do jogo de 21.
    /// Herda a construção e o embaralhamento da classe Baralho
    /// e acrescenta a retirada de cartas.
    /// </summary>
    internal class Baralho21 : Baralho
    {
        public Baralho21()
        {
            // O construtor da classe Baralho já montou as cartas.
            embaralha();
        }

        public int CartasRestantes
        {
            get { return cartas.Length; }
        }

        /// <summary>
        /// Retira e devolve a carta do topo do baralho.
        /// </summary>
        public Carta PegarCarta()
        {
            if (cartas.Length == 0)
            {
                throw new InvalidOperationException("Não há mais cartas no baralho.");
            }

            Carta topo = cartas[cartas.Length - 1];

            Carta[] restantes = new Carta[cartas.Length - 1];
            Array.Copy(cartas, restantes, restantes.Length);

            setCartas(restantes);
            quantidadeDeCartas = restantes.Length;

            return topo;
        }
    }
}
