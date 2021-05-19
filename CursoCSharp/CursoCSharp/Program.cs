using System;
using System.Text;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {

            /*
            int value = int.Parse(Console.ReadLine());
            int count = 1;
            
            while(count <= value) {

                if(count % 2 != 0) {
                    Console.WriteLine(count);
                }
                count++;
            } 

            Triangulo X = new Triangulo();
            Triangulo Y = new Triangulo();

            X.LadoA = double.Parse(Console.ReadLine());
            X.LadoB = double.Parse(Console.ReadLine());
            X.LadoC = double.Parse(Console.ReadLine());


            Y.LadoA = double.Parse(Console.ReadLine());
            Y.LadoB = double.Parse(Console.ReadLine());
            Y.LadoC = double.Parse(Console.ReadLine());
            */

            //Console.WriteLine(X.ToString());
            //Console.WriteLine(X.CalculaArea());
            //Console.WriteLine(Y.ToString());
            //Console.WriteLine(Y.CalculaArea());

            Console.WriteLine(AlgumaCoisa(1,3));

            Triangulo t = new Triangulo() {
                LadoA = 1,
                LadoB = 2,
                LadoC = 3
            };
            StringBuilder sb = new StringBuilder();
            sb.Append("Área = ");
            sb.Append(t.CalculaArea());
            sb.Append(" ");
            sb.Append("Dados \n");
            sb.Append(t.ToString());
            Console.WriteLine(sb.ToString());

            t.teste = "arroba";
            Console.WriteLine(t.teste);

        }

        static double AlgumaCoisa(double a = 0) {

            return a * 2;
        }

        static double AlgumaCoisa(double a = 0, double b = 0) {
            return a + b;
        }
    }
}

