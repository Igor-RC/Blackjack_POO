using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Jogo21
{
    /// <summary>
    /// Interface gráfica: recebe os cliques e mostra a situação do jogo.
    /// As regras ficam na classe Jogo.
    /// </summary>
    public partial class Form1 : Form
    {
        private const double ProporcaoCarta = 338.0 / 489.0;
        private const int EspacoEntreCartas = 12;

        private Jogo jogo;

        public Form1()
        {
            InitializeComponent();
            IniciarPartida();
        }

        private void btnPedirCarta_Click(object sender, EventArgs e)
        {
            jogo.PedirCarta();
            AtualizarTela();
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            jogo.Parar();
            AtualizarTela();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            IniciarPartida();
        }

        // A cada intervalo do Timer, a banca faz um passo da sua jogada.
        private void tmrBanca_Tick(object sender, EventArgs e)
        {
            if (jogo.Estado == EstadoJogo.VezDaBanca)
            {
                jogo.JogadaDaBanca();
                AtualizarTela();
            }
        }

        private void IniciarPartida()
        {
            tmrBanca.Stop();
            jogo = new Jogo();
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            bool vezDoJogador = jogo.Estado == EstadoJogo.VezDoJogador;

            // A segunda carta da banca fica virada durante a vez do jogador.
            MostrarCartas(pnlBanca, jogo.Banca.ObterCartas(), vezDoJogador);
            MostrarCartas(pnlJogador, jogo.Jogador.ObterCartas(), false);

            lblBanca.Text = vezDoJogador
                ? "Banca: " + jogo.Banca.PontosVisiveis + " + ?"
                : "Banca: " + jogo.Banca.Pontos + " pontos";
            lblJogador.Text = "Jogador: " + jogo.Jogador.Pontos + " pontos";

            btnPedirCarta.Enabled = vezDoJogador;
            btnParar.Enabled = vezDoJogador;

            AtualizarMensagem();

            tmrBanca.Enabled = jogo.Estado == EstadoJogo.VezDaBanca;
        }

        private void AtualizarMensagem()
        {
            lblMensagem.ForeColor = Color.White;

            switch (jogo.Estado)
            {
                case EstadoJogo.VezDoJogador:
                    lblMensagem.Text = "Sua vez: peça uma carta ou pare.";
                    break;

                case EstadoJogo.VezDaBanca:
                    lblMensagem.Text = jogo.Jogador.Pontos == Jogador.Limite
                        ? "Você fez 21! Vez da banca..."
                        : "Vez da banca...";
                    break;

                case EstadoJogo.Encerrado:
                    lblMensagem.Text = DescreverResultado();
                    lblMensagem.ForeColor = jogo.Resultado == Resultado.VitoriaJogador
                        ? Color.Gold
                        : Color.LightSalmon;
                    break;
            }
        }

        private string DescreverResultado()
        {
            if (jogo.Jogador.Estourou)
            {
                return "Você ultrapassou 21. A banca venceu!";
            }

            if (jogo.Banca.Estourou)
            {
                return "A banca ultrapassou 21. Você venceu!";
            }

            if (jogo.Jogador.Pontos == jogo.Banca.Pontos)
            {
                return "Empate em " + jogo.Banca.Pontos + ". A vitória é da banca!";
            }

            return jogo.Resultado == Resultado.VitoriaJogador
                ? "Você venceu!"
                : "A banca venceu!";
        }

        private void MostrarCartas(Panel painel, IReadOnlyList<Carta> cartas,
                                   bool esconderSegunda)
        {
            painel.SuspendLayout();

            // Remove as imagens da atualização anterior.
            while (painel.Controls.Count > 0)
            {
                painel.Controls[0].Dispose();
            }

            int altura = painel.ClientSize.Height;
            int largura = (int)(altura * ProporcaoCarta);

            // Distância entre cartas: se não couberem lado a lado, sobrepõe.
            int passo = largura + EspacoEntreCartas;
            if (cartas.Count > 1)
            {
                int passoMaximo = (painel.ClientSize.Width - largura) / (cartas.Count - 1);
                passo = Math.Min(passo, passoMaximo);
            }

            // Centraliza o conjunto no painel.
            int larguraTotal = largura + passo * (cartas.Count - 1);
            int inicio = (painel.ClientSize.Width - larguraTotal) / 2;

            for (int i = 0; i < cartas.Count; i++)
            {
                bool virada = esconderSegunda && i == 1;

                PictureBox figura = new PictureBox
                {
                    Image = virada ? ImagemCarta.Verso() : ImagemCarta.Frente(cartas[i]),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(largura, altura),
                    Location = new Point(inicio + i * passo, 0)
                };

                painel.Controls.Add(figura);
                figura.BringToFront(); // a carta mais nova fica por cima
            }

            painel.ResumeLayout();
        }
    }
}
