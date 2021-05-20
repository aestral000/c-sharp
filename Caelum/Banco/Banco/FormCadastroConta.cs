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
    public partial class FormCadastroConta : Form {
        private Form1 formPrincipal;

        public Form1 FormPrincipal { get; set; }
        public FormCadastroConta(Form1 formPrincipal) {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void FormCadastroConta_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void botaoCadastro_Click(object sender, EventArgs e) {
            Conta novaConta = new ContaCorrente();
            novaConta.Titular = new Cliente(TextoTitularCadastro.Text);
            novaConta.Numero = Convert.ToInt32(textoNumeroCadastro.Text);
            this.formPrincipal.AdicionaConta(novaConta);

        }
    }
}
