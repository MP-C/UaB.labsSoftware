using System.Threading;

namespace Formulario_correto
{
    public partial class BoasVindas : Form
    {
        Thread t1;
        public BoasVindas()
        {
            InitializeComponent();
        }

        private void btnEfetuarDonativo_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirJanela); // Criei o metodo abrir janela
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirJanela(object obj)
        {
            Application.Run(new Formulario());
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem a certeza que pretende fechar a aplicação?", "Fechar Aplicação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("A aplicação foi fechada com sucesso.", "Aplicação Encerrada!", MessageBoxButtons.OK);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                this.Activate();
            }
        }
    }
}