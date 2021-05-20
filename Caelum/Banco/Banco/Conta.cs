using System;

namespace Banco {
    public abstract class Conta {

        private int numero;
        private double saldo;
        private Cliente titular;

        public int Numero { get { return numero; } set { this.numero = value; } }
        public double Saldo { get { return saldo; } set { saldo = value; } }
        public Cliente Titular { get { return titular; } set { titular = value; } }

        public virtual bool Deposita(double valorOperacao) => false;
         

        public virtual bool Saca(double valorOperacao) {
            if (valorOperacao < Saldo) {
                saldo -= valorOperacao;
                return true;
            }

            return false;
        }
    }
}
