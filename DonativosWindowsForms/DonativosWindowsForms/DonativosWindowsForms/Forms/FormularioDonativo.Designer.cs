using DonativosWindowsForms.Views;

namespace DonativosWindowsForms.Forms
{
    public partial class FormularioDonativo
    {
        private ViewFormulario view;
        public ViewFormulario View { get => view; set => view = value; }
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.labelPais = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelCodigoPostal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEfetuarDonativo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.comboAnonimato = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtTelemovel = new System.Windows.Forms.TextBox();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.labelEuros = new System.Windows.Forms.Label();
            this.labelAnonimato = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelTelemovel = new System.Windows.Forms.Label();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.labelMorada = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPais
            // 
            this.txtPais.Location = new System.Drawing.Point(39, 194);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(125, 27);
            this.txtPais.TabIndex = 25;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(181, 141);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(125, 27);
            this.txtCidade.TabIndex = 24;
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Location = new System.Drawing.Point(39, 141);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(125, 27);
            this.txtCodigoPostal.TabIndex = 23;
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(39, 171);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(34, 20);
            this.labelPais.TabIndex = 38;
            this.labelPais.Text = "País";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Location = new System.Drawing.Point(181, 118);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(56, 20);
            this.labelCidade.TabIndex = 37;
            this.labelCidade.Text = "Cidade";
            // 
            // labelCodigoPostal
            // 
            this.labelCodigoPostal.AutoSize = true;
            this.labelCodigoPostal.Location = new System.Drawing.Point(39, 120);
            this.labelCodigoPostal.Name = "labelCodigoPostal";
            this.labelCodigoPostal.Size = new System.Drawing.Size(101, 20);
            this.labelCodigoPostal.TabIndex = 36;
            this.labelCodigoPostal.Text = "Código Postal";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEfetuarDonativo);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 451);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 36);
            this.panel1.TabIndex = 35;
            // 
            // btnEfetuarDonativo
            // 
            this.btnEfetuarDonativo.Location = new System.Drawing.Point(3, 3);
            this.btnEfetuarDonativo.Name = "btnEfetuarDonativo";
            this.btnEfetuarDonativo.Size = new System.Drawing.Size(94, 29);
            this.btnEfetuarDonativo.TabIndex = 2;
            this.btnEfetuarDonativo.Text = "Efetuar Donativo";
            this.btnEfetuarDonativo.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(249, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(94, 29);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(39, 407);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(267, 27);
            this.txtMensagem.TabIndex = 32;
            // 
            // comboAnonimato
            // 
            this.comboAnonimato.FormattingEnabled = true;
            this.comboAnonimato.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.comboAnonimato.Location = new System.Drawing.Point(39, 353);
            this.comboAnonimato.Name = "comboAnonimato";
            this.comboAnonimato.Size = new System.Drawing.Size(125, 28);
            this.comboAnonimato.TabIndex = 30;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(39, 300);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(125, 27);
            this.txtValor.TabIndex = 29;
            // 
            // txtTelemovel
            // 
            this.txtTelemovel.Location = new System.Drawing.Point(39, 247);
            this.txtTelemovel.Name = "txtTelemovel";
            this.txtTelemovel.Size = new System.Drawing.Size(125, 27);
            this.txtTelemovel.TabIndex = 26;
            // 
            // labelMensagem
            // 
            this.labelMensagem.AutoSize = true;
            this.labelMensagem.Location = new System.Drawing.Point(39, 384);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(82, 20);
            this.labelMensagem.TabIndex = 34;
            this.labelMensagem.Text = "Mensagem";
            // 
            // labelEuros
            // 
            this.labelEuros.AutoSize = true;
            this.labelEuros.Location = new System.Drawing.Point(170, 303);
            this.labelEuros.Name = "labelEuros";
            this.labelEuros.Size = new System.Drawing.Size(45, 20);
            this.labelEuros.TabIndex = 33;
            this.labelEuros.Text = "Euros";
            // 
            // labelAnonimato
            // 
            this.labelAnonimato.AutoSize = true;
            this.labelAnonimato.Location = new System.Drawing.Point(39, 330);
            this.labelAnonimato.Name = "labelAnonimato";
            this.labelAnonimato.Size = new System.Drawing.Size(83, 20);
            this.labelAnonimato.TabIndex = 31;
            this.labelAnonimato.Text = "Anonimato";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(39, 277);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(43, 20);
            this.labelValor.TabIndex = 28;
            this.labelValor.Text = "Valor";
            // 
            // labelTelemovel
            // 
            this.labelTelemovel.AutoSize = true;
            this.labelTelemovel.Location = new System.Drawing.Point(39, 224);
            this.labelTelemovel.Name = "labelTelemovel";
            this.labelTelemovel.Size = new System.Drawing.Size(77, 20);
            this.labelTelemovel.TabIndex = 27;
            this.labelTelemovel.Text = "Telemovel";
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(39, 90);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(267, 27);
            this.txtMorada.TabIndex = 22;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(39, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 27);
            this.txtNome.TabIndex = 20;
            // 
            // labelMorada
            // 
            this.labelMorada.AutoSize = true;
            this.labelMorada.Location = new System.Drawing.Point(39, 67);
            this.labelMorada.Name = "labelMorada";
            this.labelMorada.Size = new System.Drawing.Size(61, 20);
            this.labelMorada.TabIndex = 21;
            this.labelMorada.Text = "Morada";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(39, 14);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(50, 20);
            this.labelNome.TabIndex = 19;
            this.labelNome.Text = "Nome";
            // 
            // FormularioDonativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 487);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtCodigoPostal);
            this.Controls.Add(this.labelPais);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.labelCodigoPostal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.comboAnonimato);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtTelemovel);
            this.Controls.Add(this.labelMensagem);
            this.Controls.Add(this.labelEuros);
            this.Controls.Add(this.labelAnonimato);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelTelemovel);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labelMorada);
            this.Controls.Add(this.labelNome);
            this.Name = "FormularioDonativo";
            this.Text = "FormularioDonativo";
            this.Load += new System.EventHandler(this.FormularioDonativo_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPais;
        private TextBox txtCidade;
        private TextBox txtCodigoPostal;
        private Label labelPais;
        private Label labelCidade;
        private Label labelCodigoPostal;
        private Panel panel1;
        private Button btnEfetuarDonativo;
        private Button btnFechar;
        private TextBox txtMensagem;
        private ComboBox comboAnonimato;
        private TextBox txtValor;
        private TextBox txtTelemovel;
        private Label labelMensagem;
        private Label labelEuros;
        private Label labelAnonimato;
        private Label labelValor;
        private Label labelTelemovel;
        private TextBox txtMorada;
        private TextBox txtNome;
        private Label labelMorada;
        private Label labelNome;
    }
}