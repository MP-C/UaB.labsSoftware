using DonativosWindowsForms.Forms;
using DonativosWindowsForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DonativosWindowsForms.Views
{
    public class ViewFormulario
    {
        private FormularioDonativo formularioDonativo;

        public event Action UtilizadorClicouEmSair;

        private Model model;

        public void ActivarInterface()
        {
            formularioDonativo = new FormularioDonativo();
            formularioDonativo.ViewDonativo = this;
            formularioDonativo.Show();
        }

        public void Sair()
        {
            if(UtilizadorClicouEmSair != null)
            {
                UtilizadorClicouEmSair();
            }
            
        }

        //alterar o processar donativo da viewDonativo para aqui!!!

        public void Encerrar()
        {
            formularioDonativo.Encerrar();
        }

    }
}
