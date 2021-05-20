using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo.Entities {
    class Conta {
        public int numero;
        public Cliente titular;
        public double saldo;



        public bool Sacar(double value) {
            if (saldo > value) {
                saldo -= value;
                return true;
            }

            return false;

        }
    }
}
