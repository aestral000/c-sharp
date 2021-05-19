using System;
using System.Collections.Generic;

namespace Testes {
    class Program {
        static void Main(string[] args) {
            double? valor1 = null;
            double valor2;

            valor2 = valor1 ?? 2.0;

            Console.WriteLine(valor2);
            double[] valor = new double[3];

            Console.WriteLine(Soma(1, 2, 3, 4, 5, 6, 7));
            int val = 2;
            Duplica(ref val);
            Console.WriteLine(val);

            List<string> nome = new List<string>();

            nome.Add("um");
            nome.Add("dois");
            nome.Add("tres");
            nome.Add("quatro");
            Console.WriteLine(nome.Find(x => x.Equals("tres")));
           
        }

        static double? GetValor(double? valor = 0) {
            return valor;
        }

        static int Soma(params int[] valores) {
            int sum = 0;
            for (int i = 0; i < valores.Length; i++) {
                sum += valores[i];
            }
            return sum;
        }

        static void Duplica(ref int valor) {
            valor *= 2;
        }
    }
}
