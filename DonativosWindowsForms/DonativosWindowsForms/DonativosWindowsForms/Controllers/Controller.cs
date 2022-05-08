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

        public Controller()
        {
            view = new ViewDonativos(model);
            viewFormulario = new ViewFormulario();
            model = new Model(viewFormulario);
            menuIniciar = new ViewMenuIniciar();

            viewFormulario.UtilizadorClicouEmSair += UtilizadorClicouEmSair;
            menuIniciar.UtilizadorClicouEmSair += UtilizadorClicouEmSair;
        }

        public void IniciarPrograma()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuInicial());
        }

        public void UtilizadorClicouEmSair()
        {
            viewFormulario.Encerrar();
        }
    }
  
  
}
