
namespace Banco {
    partial class FormCadastroConta {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoNumeroCadastro = new System.Windows.Forms.TextBox();
            this.TextoTitularCadastro = new System.Windows.Forms.TextBox();
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular";
            // 
            // textoNumeroCadastro
            // 
            this.textoNumeroCadastro.Location = new System.Drawing.Point(12, 53);
            this.textoNumeroCadastro.Name = "textoNumeroCadastro";
            this.textoNumeroCadastro.Size = new System.Drawing.Size(354, 23);
            this.textoNumeroCadastro.TabIndex = 2;
            // 
            // TextoTitularCadastro
            // 
            this.TextoTitularCadastro.Location = new System.Drawing.Point(12, 106);
            this.TextoTitularCadastro.Name = "TextoTitularCadastro";
            this.TextoTitularCadastro.Size = new System.Drawing.Size(354, 23);
            this.TextoTitularCadastro.TabIndex = 3;
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.Location = new System.Drawing.Point(123, 146);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(124, 23);
            this.botaoCadastro.TabIndex = 4;
            this.botaoCadastro.Text = "Cadastro";
            this.botaoCadastro.UseVisualStyleBackColor = true;
            this.botaoCadastro.Click += new System.EventHandler(this.botaoCadastro_Click);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 247);
            this.Controls.Add(this.botaoCadastro);
            this.Controls.Add(this.TextoTitularCadastro);
            this.Controls.Add(this.textoNumeroCadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoNumeroCadastro;
        private System.Windows.Forms.TextBox TextoTitularCadastro;
        private System.Windows.Forms.Button botaoCadastro;
    }
}