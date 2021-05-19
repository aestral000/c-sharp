using System;
using System.Text;


namespace ExercicioContaBancaria {
    class Conta {

        private string _titular;
        private string _numero;
        private double _saldo;

        public Conta(string titular, string numero) {
            _titular = titular;
            _numero = numero;
        }

        public Conta() {

        }

        public String Titular {
            get { return _titular; }
            set { _titular = value; }
        }

        public String Numero {
            get { return _numero; }
            set { _numero = value; }
        }

        public double Saldo {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public double Depositar(double deposito) {
            if (deposito > 0) {
                _saldo = deposito - 5;
            }
            return _saldo;
        }

        public double Sacar(double valor) {
            if (valor > 0) {
                _saldo -= valor + 5;
            }
            return _saldo;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("Dados da conta: \n");
            sb.Append("\n");
            sb.Append("Titular: ");
            sb.Append(_titular);
            sb.Append("\n");
            sb.Append("Número: ");
            sb.Append(_numero);
            sb.Append("\n");
            sb.Append("Saldo: ");
            sb.Append(_saldo);
            sb.Append("\n");

            return sb.ToString();
        }
    }
}
