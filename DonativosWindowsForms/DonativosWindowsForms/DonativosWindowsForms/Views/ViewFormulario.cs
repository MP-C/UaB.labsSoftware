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

        public void ProcessarDonativo(string nome, string morada, string codigopostal, string cidade, string pais, string telemovel, decimal montante, string mensagem)
        {
            Model model = new Model(this);
            try
            {
                model.ProcessarDonativo(nome, morada, codigopostal, cidade, pais, telemovel, montante, mensagem);
            } 
            catch
            {
                ViewLog viewLog = new ViewLog();
                viewLog.ActivarInterface();
                //falta registar erro
            }
           
        }


        public void NotificacaoDeLogAlterado()
        {
            /*
            string texto = "";
            List<ILogItem> itens = PrecisoDeLog();
            foreach (ILogItem item in itens)
                texto += item.Tipo + ": " + item.Mensagem + Environment.NewLine;
            viewlog.AlterarLog(texto);*/
        }


        public void Encerrar()
        {
            formularioDonativo.Encerrar();
        }



    }
}
