using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    public class TotalizadorDeContas {
    
        private double total;
        public double Total { get { return total; } set { total = value; } }

        public void Soma(Conta c) {
            Total += c.Saldo;
        }

        public void Acumula(ContaPoupança cp) {
            Total += cp.CalculaTributo();
        }
        public void Acumula(ContaInvestimento ci) {
            Total += ci.CalculaTributo();
        }


    }
}
