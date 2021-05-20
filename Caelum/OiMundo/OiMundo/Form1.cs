using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OiMundo.Entities;

namespace OiMundo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Cliente cl1 = new Cliente();
            Cliente cl2 = new Cliente();
            Conta co1 = new Conta();
            co1.titular = cl1;
            co1.titular.nome = "Carla";
            co1.titular.rg = "12345678 - 9";
            Conta co2 = new Conta();
            co2.titular = cl2;
            co2.titular.nome = "Marta";
            co2.titular.rg = "98765432-1";



            MessageBox.Show(co1.titular.nome);
        }

        private double RetornaMedia() {
            return (10 + 25) / 2;
        }
    }
}
