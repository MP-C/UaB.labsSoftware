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
    public partial class MenuInicial : Form
    {
        private ViewFormulario viewFormulario;
        public ViewMenuIniciar viewMenuIniciar { get => view; set => view = value; }

        public MenuInicial()
        {
            ControlBox = false;
            InitializeComponent();
        }

        private void btnEfetuarDonativo_Click(object sender, EventArgs e)
        {
            viewFormulario = new ViewFormulario();
            viewFormulario.ActivarInterface();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            viewMenuIniciar.Sair();
        }
    }
}
