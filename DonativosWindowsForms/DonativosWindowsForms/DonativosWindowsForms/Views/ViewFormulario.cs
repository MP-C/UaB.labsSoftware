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
        public void ActivarInterface()
        {
            formularioDonativo = new FormularioDonativo();
            formularioDonativo.View = this;
            formularioDonativo.Show();
        }
       
    }
}
