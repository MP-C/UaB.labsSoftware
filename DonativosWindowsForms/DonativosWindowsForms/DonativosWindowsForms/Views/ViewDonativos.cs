using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonativosWindowsForms.Forms;
using DonativosWindowsForms.Models;
using static DonativosWindowsForms.Models.Logger;

namespace DonativosWindowsForms.Views
{
    public class ViewDonativos
    {
        private Model model;

        private RespostaFinal respostaFinal;

        public ViewDonativos(Model m)
        {
            model = m;
        }

        public void ActivarInterface(decimal totais, decimal montante)
        {
            respostaFinal = new RespostaFinal();
            respostaFinal.AtualizarTotais(totais);
            respostaFinal.MostrarMontante(montante);
            respostaFinal.Show();
        }

    }
}
