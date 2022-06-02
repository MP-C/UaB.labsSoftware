using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DonativosWindowsForms.Forms;
using DonativosWindowsForms.Models;
using DonativosWindowsForms.Views;


namespace DonativosWindowsForms.Controllers
{
  
    public class Controller
    {
        Model model;
        ViewDonativos view;
        ViewFormulario viewFormulario;
        ViewMenuIniciar menuIniciar;

        private bool sair;

        public Controller()
        {
            view = new ViewDonativos(model);
            viewFormulario = new ViewFormulario();
            model = new Model(viewFormulario);
            menuIniciar = new ViewMenuIniciar();

            menuIniciar.UtilizadorClicouEmSair += UtilizadorClicouEmSair;
            model.NotificarLogAlterado += viewFormulario.NotificacaoDeLogAlterado;
        }

        public void IniciarPrograma()
        {
            do
            {
                menuIniciar.ActivarInterface();
            } while (!sair);
            
        }

        public void UtilizadorClicouEmSair()
        {
            sair = true;
            menuIniciar.Encerrar();
        }
    }
  
  
}
