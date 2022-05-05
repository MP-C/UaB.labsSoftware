using DonativosWindowsForms.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonativosWindowsForms.Views
{
    public class ViewMenuIniciar
    {
        private MenuInicial menuInicial;
        public void ActivarInterface()
        {
            menuInicial = new MenuInicial();
            menuInicial.View = this;
            menuInicial.Show();
        }

    }
}
