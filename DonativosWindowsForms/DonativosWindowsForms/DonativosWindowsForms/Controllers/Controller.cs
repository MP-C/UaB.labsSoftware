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

        public Controller()
        {
            view = new ViewDonativos(model);
            model = new Model(view);
        }

        public void IniciarPrograma()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuInicial());
        }
    }
  
  
}
