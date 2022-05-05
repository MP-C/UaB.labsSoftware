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
        private ViewFormulario viewFormulario;

        public ViewFormulario View { get => view; set => view = value; }


        public FormularioDonativo()
        {
            InitializeComponent();
        }

        private void FormularioDonativo_Load(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            ViewFormulario viewFormulario = new ViewFormulario();
            viewFormulario.Sair();
            
        }
    }
}
