using System.Linq;

namespace Jogo21
{
    /// <summary>
    /// A banca é um jogador que decide sozinho quando pedir cartas.
    /// </summary>
    internal class Banca : Jogador
    {
        /// <summary>
        /// Pontos da única carta que fica à mostra durante a vez do jogador.
        /// </summary>
        public int PontosVisiveis
        {
            get { return CalcularPontos(ObterCartas().Take(1)); }
        }

        /// <summary>
        /// Estratégia da banca: como o empate é dela, basta pedir cartas
        /// enquanto tiver menos pontos que o jogador. Ao igualar ou superar,
        /// ela para, pois já venceu.
        /// </summary>
        public bool DevePedirCarta(int pontosDoJogador)
        {
            return Pontos < pontosDoJogador;
        }
    }
}
