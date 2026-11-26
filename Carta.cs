using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Jogo21
{
    internal class Carta
    {
        private string naipe = "";
        private string valor = "";
        private double peso = 1.0;

        protected string[] valoresPermitidos = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"},
                         naipesPermitidos  = {"copas", "ouros", "paus", "espadas" };

        public Carta() { }

        public Carta(string valor, string naipe)
        {
            setNaipe(naipe);
            setValor(valor);
        }

        public Carta(string valor, string naipe, double peso)
        {
            setNaipe(naipe);
            setValor(valor);
            setPeso(peso);
        }

        public Carta(string valor, string naipe, double peso, 
                                    string[] valoresPermitidos,
                                    string[] naipesPermitidos)
        {
            setNaipe(naipe);
            setValor(valor);
            setPeso(peso);
            setNaipesPermitidos(naipesPermitidos);
            setValoresPermitidos(valoresPermitidos);
        }

        public void setValoresPermitidos(string[] valoresPermitidos)
        {
            this.valoresPermitidos = valoresPermitidos;
        }
        public void setNaipesPermitidos(string[] naipesPermitidos)
        {
            this.naipesPermitidos = naipesPermitidos;
        }

        public string[] getValoresPermitidos()
        {
            return this.valoresPermitidos;
        }
        public string[] getNaipesPermitidos()
        {
            return this.naipesPermitidos;
        }
        public void setNaipe(string naipe)
        {
            if (naipesPermitidos.Contains(naipe))
            {
                this.naipe = naipe;
            }
            else
            {
                Console.WriteLine("Naipe não permitido!");
            }
        }
        public void setValor(string valor)
        {
            if (valoresPermitidos.Contains(valor))
            {
                this.valor = valor;
            }
            else
            {
                Console.WriteLine("Valor não permitido!");
            }
        }

        public string getNaipe()
        {
            return this.naipe;
        }

        public string getValor()
        {
            return this.valor;
        }

        public void setPeso(double peso)
        {
            if(peso > 0)
            {
                this.peso = peso;
            }
            else
            {
                Console.WriteLine("Peso deve ser um valor positivo");
            }
        }
        public double getPeso()
        {
            return this.peso;
        }

        public static bool operator ==(Carta c1, Carta c2)
        {
            if (c1.getPeso() == c2.getPeso()) return true;

            return false;
        }
        public static bool operator !=(Carta c1, Carta c2)
        {
            if (c1.getPeso() != c2.getPeso()) return true;

            return false;
        }


        public static bool operator >(Carta c1, Carta c2)
        {
            if (c1.getPeso() > c2.getPeso()) return true;

            return false;
        }
        public static bool operator <(Carta c1, Carta c2)
        {
            if (c1.getPeso() < c2.getPeso()) return true;

            return false;
        }


        public static bool operator >=(Carta c1, Carta c2)
        {
            if (c1.getPeso() >= c2.getPeso()) return true;

            return false;
        }
        public static bool operator <=(Carta c1, Carta c2)
        {
            if (c1.getPeso() <= c2.getPeso()) return true;

            return false;
        }

    }
}
