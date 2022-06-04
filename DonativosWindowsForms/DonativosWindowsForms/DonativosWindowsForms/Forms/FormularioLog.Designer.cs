using DonativosWindowsForms.Views;

namespace DonativosWindowsForms.Forms
{
    partial class FormularioLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private ViewLog view;
        public ViewLog View { get => view; set => view = value; }

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
            this.labelErrors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelErrors
            // 
            this.labelErrors.AutoSize = true;
            this.labelErrors.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelErrors.Location = new System.Drawing.Point(114, 79);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(224, 25);
            this.labelErrors.TabIndex = 0;
            this.labelErrors.Text = "Valor tem de ser decimal.";
            this.labelErrors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelErrors.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormularioLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 190);
            this.Controls.Add(this.labelErrors);
            this.Name = "FormularioLog";
            this.Text = "FormularioLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelErrors;
    }
}