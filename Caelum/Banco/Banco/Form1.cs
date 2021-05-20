using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco {
    public partial class Form1 : Form {

        private Conta[] contas;
        private int numeroDeContas;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            this.contas = new Conta[10];

            Conta c1 = new Conta();
            c1.Titular = new Cliente("victor");
            c1.Numero = 1;
            this.AdicionaConta(c1);
            Conta c2 = new ContaPoupança();
            c2.Titular = new Cliente("mauricio");
            c2.Numero = 2;
            this.AdicionaConta(c2);
            Conta c3 = new ContaCorrente();
            c3.Titular = new Cliente("osni");
            c3.Numero = 3;
            this.AdicionaConta(c3);
            MessageBox.Show(Convert.ToString(numeroDeContas));

        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        public void AdicionaConta(Conta conta) {
            contas[numeroDeContas] = conta;
            numeroDeContas++;
            comboContas.Items.Add("titular ->" + conta.Titular.Nome);

        }

        private void Sacar_Click(object sender, EventArgs e) {
            string valorDigitado = textoValor.Text;
            if (valorDigitado != null) {
                double valorOperacao = Convert.ToDouble(valorDigitado);
                if (contas[GetIndex()].Saca(valorOperacao))
                    MessageBox.Show("Sucesso");
                else
                    MessageBox.Show("Falha");
            }
            textoSaldo.Text = Convert.ToString(contas[GetIndex()].Saldo);
        }

        private void Depositar_Click(object sender, EventArgs e) {

            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            if (contas[GetIndex()].Deposita(valorOperacao))
                MessageBox.Show("Sucesso");
            else
                MessageBox.Show("Falha");

            textoSaldo.Text = Convert.ToString(contas[GetIndex()].Saldo);

        }


        private int GetIndex() {
            return comboContas.SelectedIndex;
        }
        private void Buscar_Click(object sender, EventArgs e) {

            Conta selected = contas[GetIndex()];
            textoNumero.Text = Convert.ToString(selected.Numero);
            textoTitular.Text = selected.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selected.Saldo);
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e) {
            Conta selected = contas[GetIndex()];
            textoNumero.Text = Convert.ToString(selected.Numero);
            textoTitular.Text = Convert.ToString(selected.Titular.Nome);
            textoSaldo.Text = Convert.ToString(selected.Saldo);
        }

        private void botaoNovaConta_Click(object sender, EventArgs e) {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();

        }
    }
}
