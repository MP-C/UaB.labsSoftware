using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonativosWindowsForms.Forms;
using DonativosWindowsForms.Models;

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

        public void ActivarInterface()
        {
            respostaFinal = new RespostaFinal();
            respostaFinal.Show();
        }

        //este metodo tem que ser alterado para a viewFormulario

        public void ProcessarDonativo(string nome, string morada, string codigopostal, string cidade, string pais, string telemovel, decimal montante, string mensagem)
        {
            Model model = new Model(this);
            model.ProcessarDonativo(nome,morada, codigopostal, cidade, pais, telemovel, montante, mensagem);
        }

    }
}
