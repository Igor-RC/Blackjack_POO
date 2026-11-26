using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Jogo21
{
    /// <summary>
    /// Relaciona cada carta com o arquivo de imagem da pasta deck_2.
    /// </summary>
    internal static class ImagemCarta
    {
        private static readonly string Pasta =
            Path.Combine(Application.StartupPath, "deck_2");

        // Cada imagem é lida do disco uma única vez e depois reaproveitada.
        private static readonly Dictionary<string, Image> Carregadas =
            new Dictionary<string, Image>();

        public static Image Frente(Carta carta)
        {
            string arquivo = TraduzirNaipe(carta.getNaipe()) + "_" +
                             TraduzirValor(carta.getValor()) + ".png";

            return Carregar(arquivo);
        }

        public static Image Verso()
        {
            return Carregar("back.png");
        }

        private static Image Carregar(string arquivo)
        {
            Image imagem;

            if (!Carregadas.TryGetValue(arquivo, out imagem))
            {
                imagem = Image.FromFile(Path.Combine(Pasta, arquivo));
                Carregadas.Add(arquivo, imagem);
            }

            return imagem;
        }

        private static string TraduzirNaipe(string naipe)
        {
            switch (naipe)
            {
                case "copas": return "heart";
                case "ouros": return "diamond";
                case "paus": return "club";
                case "espadas": return "spade";
                default: throw new ArgumentException("Naipe desconhecido: " + naipe);
            }
        }

        private static string TraduzirValor(string valor)
        {
            switch (valor)
            {
                case "A": return "1";
                case "J": return "jack";
                case "Q": return "queen";
                case "K": return "king";
                default: return valor;
            }
        }
    }
}
