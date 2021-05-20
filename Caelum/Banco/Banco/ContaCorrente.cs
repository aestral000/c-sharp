namespace Banco {
    public class ContaCorrente : Conta {

        public override bool Saca(double valorOperacao) {
            if(valorOperacao < Saldo) {
                this.Saldo -= (valorOperacao + 0.10);
                return true;
            }
            return false;

        }
    }
}