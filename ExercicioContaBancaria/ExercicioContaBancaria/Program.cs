using System;

namespace ExercicioContaBancaria {
    class Program {
        static void Main(string[] args) {
            
            Conta conta = new Conta();
            Console.WriteLine("Número da conta: ");
            conta.Numero = Console.ReadLine();
            Console.WriteLine("Titular: ");
            conta.Titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n)? ");
            if (Console.ReadLine().Equals("s")) {
                Console.WriteLine("Digite o valor depositado: ");
                double deposito = double.Parse(Console.ReadLine());
                conta.Depositar(deposito);
            }
            Console.WriteLine(conta.ToString());

            Console.WriteLine("Deposite um valor: ");
            conta.Depositar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados com sucesso!");
            Console.WriteLine(conta.ToString());

            Console.WriteLine("Saque uma quantia: ");
            conta.Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados atualizados com sucesso!");
            Console.WriteLine(conta.ToString());

        }
    }
}
