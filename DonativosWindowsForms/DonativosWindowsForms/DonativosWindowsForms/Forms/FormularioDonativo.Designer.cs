using DonativosWindowsForms.Views;

namespace DonativosWindowsForms.Forms
{
    public partial class FormularioDonativo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private ViewFormulario view;

        public ViewFormulario ViewDonativo { get => view; set => view = value; }

        public void Encerrar()
        {
            Application.Exit();
        }

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
            this.button1 = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxMorada = new System.Windows.Forms.TextBox();
            this.Morada = new System.Windows.Forms.Label();
            this.textBoxCodigoPostal = new System.Windows.Forms.TextBox();
            this.CodigoPostal = new System.Windows.Forms.Label();
            this.textBoxCidade = new System.Windows.Forms.TextBox();
            this.Cidade = new System.Windows.Forms.Label();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.Pais = new System.Windows.Forms.Label();
            this.textBoxTelemovel = new System.Windows.Forms.TextBox();
            this.Telemovel = new System.Windows.Forms.Label();
            this.textBoxMontante = new System.Windows.Forms.TextBox();
            this.Montante = new System.Windows.Forms.Label();
            this.textBoxMensagem = new System.Windows.Forms.TextBox();
            this.Mensagem = new System.Windows.Forms.Label();
            this.Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(37, 33);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(50, 20);
            this.Nome.TabIndex = 1;
            this.Nome.Text = "Nome";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(37, 56);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(340, 27);
            this.textBoxNome.TabIndex = 2;
            // 
            // textBoxMorada
            // 
            this.textBoxMorada.Location = new System.Drawing.Point(37, 128);
            this.textBoxMorada.Name = "textBoxMorada";
            this.textBoxMorada.Size = new System.Drawing.Size(340, 27);
            this.textBoxMorada.TabIndex = 4;
            // 
            // Morada
            // 
            this.Morada.AutoSize = true;
            this.Morada.Location = new System.Drawing.Point(37, 103);
            this.Morada.Name = "Morada";
            this.Morada.Size = new System.Drawing.Size(61, 20);
            this.Morada.TabIndex = 3;
            this.Morada.Text = "Morada";
            // 
            // textBoxCodigoPostal
            // 
            this.textBoxCodigoPostal.Location = new System.Drawing.Point(37, 191);
            this.textBoxCodigoPostal.Name = "textBoxCodigoPostal";
            this.textBoxCodigoPostal.Size = new System.Drawing.Size(191, 27);
            this.textBoxCodigoPostal.TabIndex = 6;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.AutoSize = true;
            this.CodigoPostal.Location = new System.Drawing.Point(37, 168);
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Size = new System.Drawing.Size(101, 20);
            this.CodigoPostal.TabIndex = 5;
            this.CodigoPostal.Text = "Código Postal";
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.Location = new System.Drawing.Point(37, 266);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(191, 27);
            this.textBoxCidade.TabIndex = 8;
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.Location = new System.Drawing.Point(37, 243);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(56, 20);
            this.Cidade.TabIndex = 7;
            this.Cidade.Text = "Cidade";
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(453, 59);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(324, 27);
            this.textBoxPais.TabIndex = 10;
            // 
            // Pais
            // 
            this.Pais.AutoSize = true;
            this.Pais.Location = new System.Drawing.Point(453, 36);
            this.Pais.Name = "Pais";
            this.Pais.Size = new System.Drawing.Size(34, 20);
            this.Pais.TabIndex = 9;
            this.Pais.Text = "País";
            // 
            // textBoxTelemovel
            // 
            this.textBoxTelemovel.Location = new System.Drawing.Point(453, 130);
            this.textBoxTelemovel.Name = "textBoxTelemovel";
            this.textBoxTelemovel.Size = new System.Drawing.Size(324, 27);
            this.textBoxTelemovel.TabIndex = 12;
            // 
            // Telemovel
            // 
            this.Telemovel.AutoSize = true;
            this.Telemovel.Location = new System.Drawing.Point(453, 107);
            this.Telemovel.Name = "Telemovel";
            this.Telemovel.Size = new System.Drawing.Size(77, 20);
            this.Telemovel.TabIndex = 11;
            this.Telemovel.Text = "Telemóvel";
            // 
            // textBoxMontante
            // 
            this.textBoxMontante.Location = new System.Drawing.Point(453, 203);
            this.textBoxMontante.Name = "textBoxMontante";
            this.textBoxMontante.Size = new System.Drawing.Size(324, 27);
            this.textBoxMontante.TabIndex = 14;
            // 
            // Montante
            // 
            this.Montante.AutoSize = true;
            this.Montante.Location = new System.Drawing.Point(453, 180);
            this.Montante.Name = "Montante";
            this.Montante.Size = new System.Drawing.Size(43, 20);
            this.Montante.TabIndex = 13;
            this.Montante.Text = "Valor";
            // 
            // textBoxMensagem
            // 
            this.textBoxMensagem.Location = new System.Drawing.Point(453, 278);
            this.textBoxMensagem.Multiline = true;
            this.textBoxMensagem.Name = "textBoxMensagem";
            this.textBoxMensagem.Size = new System.Drawing.Size(324, 82);
            this.textBoxMensagem.TabIndex = 16;
            // 
            // Mensagem
            // 
            this.Mensagem.AutoSize = true;
            this.Mensagem.Location = new System.Drawing.Point(453, 255);
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(82, 20);
            this.Mensagem.TabIndex = 15;
            this.Mensagem.Text = "Mensagem";
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(568, 400);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(94, 29);
            this.Fechar.TabIndex = 17;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            // 
            // FormularioDonativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 450);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.textBoxMensagem);
            this.Controls.Add(this.Mensagem);
            this.Controls.Add(this.textBoxMontante);
            this.Controls.Add(this.Montante);
            this.Controls.Add(this.textBoxTelemovel);
            this.Controls.Add(this.Telemovel);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.Pais);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.textBoxCodigoPostal);
            this.Controls.Add(this.CodigoPostal);
            this.Controls.Add(this.textBoxMorada);
            this.Controls.Add(this.Morada);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.button1);
            this.Name = "FormularioDonativo";
            this.Text = "FormularioDonativo";
            this.Load += new System.EventHandler(this.FormularioDonativo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label Nome;
        private TextBox textBoxNome;
        private TextBox textBoxMorada;
        private Label Morada;
        private TextBox textBoxCodigoPostal;
        private Label CodigoPostal;
        private TextBox textBoxCidade;
        private Label Cidade;
        private TextBox textBoxPais;
        private Label Pais;
        private TextBox textBoxTelemovel;
        private Label Telemovel;
        private TextBox textBoxMontante;
        private Label Montante;
        private TextBox textBoxMensagem;
        private Label Mensagem;
        private Button Fechar;
    }
}