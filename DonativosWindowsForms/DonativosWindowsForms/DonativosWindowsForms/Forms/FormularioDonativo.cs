using DonativosWindowsForms.Models;
using DonativosWindowsForms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DonativosWindowsForms.Forms
{
    public partial class FormularioDonativo : Form
    {
        private Model model;
        public FormularioDonativo()
        {
            InitializeComponent();
        }

        private void FormularioDonativo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewFormulario viewFormulario = new ViewFormulario();

            string nome = textBoxNome.Text;
            string morada = textBoxMorada.Text;
            string codigopostal = textBoxCodigoPostal.Text;
            string cidade = textBoxCidade.Text;
            string pais = textBoxPais.Text;
            string telemovel = textBoxTelemovel.Text;
            decimal montante = Convert.ToDecimal(textBoxMontante.Text);
            string mensagem = textBoxMensagem.Text;

            viewFormulario.ProcessarDonativo(nome, morada, codigopostal, cidade, pais, telemovel, montante, mensagem);
        }
    }
}
