namespace Formulario_correto
{
    partial class BoasVindas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBoasVindas = new System.Windows.Forms.Label();
            this.btnEfetuarDonativo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBoasVindas
            // 
            this.labelBoasVindas.AutoSize = true;
            this.labelBoasVindas.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBoasVindas.Location = new System.Drawing.Point(110, 56);
            this.labelBoasVindas.Name = "labelBoasVindas";
            this.labelBoasVindas.Size = new System.Drawing.Size(560, 46);
            this.labelBoasVindas.TabIndex = 0;
            this.labelBoasVindas.Text = "Seja bem vindo a API Donativos!!!";
            // 
            // btnEfetuarDonativo
            // 
            this.btnEfetuarDonativo.Location = new System.Drawing.Point(110, 225);
            this.btnEfetuarDonativo.Name = "btnEfetuarDonativo";
            this.btnEfetuarDonativo.Size = new System.Drawing.Size(191, 50);
            this.btnEfetuarDonativo.TabIndex = 3;
            this.btnEfetuarDonativo.Text = "Efetuar Donativo";
            this.btnEfetuarDonativo.UseVisualStyleBackColor = true;
            this.btnEfetuarDonativo.Click += new System.EventHandler(this.btnEfetuarDonativo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(479, 225);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(191, 50);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // BoasVindas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnEfetuarDonativo);
            this.Controls.Add(this.labelBoasVindas);
            this.Name = "BoasVindas";
            this.Text = "Boas Vindas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelBoasVindas;
        private Button btnEfetuarDonativo;
        private Button btnFechar;
    }
}