using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
        public class ContaPoupança : Conta, ITributavel {

        public override bool Saca(double valorOperacao) {

            if(valorOperacao < Saldo) {
                Saldo -= (valorOperacao + 0.1);
                return true;
            }
            return false;
        }

        public void CalculaRendimento() {

        }

        double ITributavel.CalcularTributo() {
            throw new NotImplementedException();
        }
    }
}
