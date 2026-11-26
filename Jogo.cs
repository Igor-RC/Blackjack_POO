using System;

namespace Jogo21
{
    /// <summary>
    /// Controla uma partida: baralho, participantes, turnos e vencedor.
    /// Não conhece nada sobre a tela.
    /// </summary>
    internal class Jogo
    {
        private const int CartasIniciais = 2;

        private readonly Baralho21 baralho;

        public Jogo()
        {
            baralho = new Baralho21();
            Jogador = new Jogador();
            Banca = new Banca();
            Estado = EstadoJogo.VezDoJogador;
            Resultado = Resultado.EmAndamento;

            DistribuirCartasIniciais();
        }

        public Jogador Jogador { get; }

        public Banca Banca { get; }

        public EstadoJogo Estado { get; private set; }

        public Resultado Resultado { get; private set; }

        /// <summary>
        /// O jogador pede uma carta. Se passar de 21, perde na hora;
        /// se fizer exatamente 21, a vez passa para a banca.
        /// </summary>
        public void PedirCarta()
        {
            ExigirEstado(EstadoJogo.VezDoJogador);

            Jogador.ReceberCarta(baralho.PegarCarta());

            if (Jogador.Estourou)
            {
                Encerrar(Resultado.VitoriaBanca);
            }
            else if (Jogador.Pontos == Jogador.Limite)
            {
                Parar();
            }
        }

        /// <summary>
        /// O jogador encerra a sua jogada e passa a vez para a banca.
        /// </summary>
        public void Parar()
        {
            ExigirEstado(EstadoJogo.VezDoJogador);

            Estado = EstadoJogo.VezDaBanca;
        }

        /// <summary>
        /// Executa UM passo da vez da banca: pede uma carta ou, se já não
        /// precisar, encerra a partida. Assim a tela mostra cada carta.
        /// </summary>
        public void JogadaDaBanca()
        {
            ExigirEstado(EstadoJogo.VezDaBanca);

            if (Banca.DevePedirCarta(Jogador.Pontos))
            {
                Banca.ReceberCarta(baralho.PegarCarta());
            }
            else
            {
                Encerrar(DefinirVencedor());
            }
        }

        private void DistribuirCartasIniciais()
        {
            for (int i = 0; i < CartasIniciais; i++)
            {
                Jogador.ReceberCarta(baralho.PegarCarta());
                Banca.ReceberCarta(baralho.PegarCarta());
            }

            // 21 já nas cartas iniciais: o jogador para automaticamente.
            if (Jogador.Pontos == Jogador.Limite)
            {
                Parar();
            }
        }

        private Resultado DefinirVencedor()
        {
            if (Banca.Estourou || Jogador.Pontos > Banca.Pontos)
            {
                return Resultado.VitoriaJogador;
            }

            // Inclui o empate.
            return Resultado.VitoriaBanca;
        }

        private void Encerrar(Resultado resultado)
        {
            Resultado = resultado;
            Estado = EstadoJogo.Encerrado;
        }

        private void ExigirEstado(EstadoJogo esperado)
        {
            if (Estado != esperado)
            {
                throw new InvalidOperationException(
                    "Ação não permitida neste momento da partida.");
            }
        }
    }
}
