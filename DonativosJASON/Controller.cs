using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonativosJASON
{
    class Controller
    {
        View view;
        Model model;

        public void IniciarPrograma()
        {
            model = new Model(this, view);
            view = new View(this, model);

            view.ApresentarBoasVindas();

            view.ApresentarFormulario();
        }

        public void PreencherFormulario()
        {
            //Nome, NIB, Morada, ID, Donativo, Valor, Kilos, Mensagem, Anonimato, 

        public string Nome;


        }


    }
}
