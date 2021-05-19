
using System;
using System.Text;

namespace CursoCSharp {
    class Triangulo {

        public double LadoA;
        public double LadoB;
        public double LadoC;

        public string teste { get; set; }

        public double CalculaArea() {

            double valor = (LadoA + LadoB + LadoC) / 2;
            return Math.Sqrt((valor * (valor - LadoA) * (valor - LadoB) * (valor - LadoC)));
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("[LadoA = " + LadoA + " LadoB = " + LadoB + " LadoC = " + LadoC + "]");
            return sb.ToString();
        }
    }
}
