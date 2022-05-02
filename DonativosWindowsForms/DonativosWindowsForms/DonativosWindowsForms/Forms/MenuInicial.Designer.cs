namespace DonativosWindowsForms.Forms
{
    partial class MenuInicial
    {
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
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnEfetuarDonativo = new System.Windows.Forms.Button();
            this.labelBoasVindas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(489, 285);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(191, 50);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnEfetuarDonativo
            // 
            this.btnEfetuarDonativo.Location = new System.Drawing.Point(120, 285);
            this.btnEfetuarDonativo.Name = "btnEfetuarDonativo";
            this.btnEfetuarDonativo.Size = new System.Drawing.Size(191, 50);
            this.btnEfetuarDonativo.TabIndex = 6;
            this.btnEfetuarDonativo.Text = "Efetuar Donativo";
            this.btnEfetuarDonativo.UseVisualStyleBackColor = true;
            this.btnEfetuarDonativo.Click += new System.EventHandler(this.btnEfetuarDonativo_Click);
            // 
            // labelBoasVindas
            // 
            this.labelBoasVindas.AutoSize = true;
            this.labelBoasVindas.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBoasVindas.Location = new System.Drawing.Point(120, 116);
            this.labelBoasVindas.Name = "labelBoasVindas";
            this.labelBoasVindas.Size = new System.Drawing.Size(560, 46);
            this.labelBoasVindas.TabIndex = 5;
            this.labelBoasVindas.Text = "Seja bem vindo a API Donativos!!!";
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnEfetuarDonativo);
            this.Controls.Add(this.labelBoasVindas);
            this.Name = "MenuInicial";
            this.Text = "MenuInicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFechar;
        private Button btnEfetuarDonativo;
        private Label labelBoasVindas;
    }
}