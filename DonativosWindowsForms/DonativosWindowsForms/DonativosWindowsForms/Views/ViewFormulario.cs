using DonativosWindowsForms.Forms;
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

        public void Encerrar()
        {
            formularioDonativo.Encerrar();
        }

    }
}
