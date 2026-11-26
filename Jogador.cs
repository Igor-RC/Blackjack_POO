using System;
using System.Collections.Generic;

namespace Jogo21
{
    /// <summary>
    /// Participante do jogo: guarda a mão de cartas e calcula os pontos.
    /// </summary>
    internal class Jogador
    {
        public const int Limite = 21;

        // Encapsulamento: somente a própria classe altera a lista.
        private readonly List<Carta> mao = new List<Carta>();

        public int Pontos
        {
            get { return CalcularPontos(mao); }
        }

        public bool Estourou
        {
            get { return Pontos > Limite; }
        }

        public void ReceberCarta(Carta carta)
        {
            if (carta is null)
            {
                throw new ArgumentNullException(nameof(carta));
            }

            mao.Add(carta);
        }

        /// <summary>
        /// Devolve as cartas da mão em uma lista somente para leitura.
        /// </summary>
        public IReadOnlyList<Carta> ObterCartas()
        {
            return mao.AsReadOnly();
        }

        /// <summary>
        /// Soma as cartas contando cada Ás como 1. Depois, se houver um Ás
        /// e não ultrapassar 21, um deles passa a valer 11 (soma mais 10).
        /// </summary>
        protected static int CalcularPontos(IEnumerable<Carta> cartas)
        {
            int total = 0;
            bool temAs = false;

            foreach (Carta carta in cartas)
            {
                total += ValorDaCarta(carta);

                if (carta.getValor() == "A")
                {
                    temAs = true;
                }
            }

            if (temAs && total + 10 <= Limite)
            {
                total += 10;
            }

            return total;
        }

        private static int ValorDaCarta(Carta carta)
        {
            switch (carta.getValor())
            {
                case "A":
                    return 1;
                case "J":
                case "Q":
                case "K":
                    return 10;
                default:
                    return int.Parse(carta.getValor());
            }
        }
    }
}
