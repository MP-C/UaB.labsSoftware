using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonativosJASON
{
    class View
    {
        // Teste joni
        private Controller controller; //variaveis da class que apenas se podem usar aqui
        private Model model; //variaveis da class

        public View(Controller c, Model m)
        // constructor, serve para se poder usar novas variaveis e
        // outras class existentes fora desta
        // para criar objeto
        {
            controller = c;
            model = m;
        }


        public void ApresentarBoasVindas()
        {
            Console.WriteLine("Bem-vindo ao Programa de Donativos internacional");
        }

        public void ApresentarFormulario()
        {
            Console.WriteLine("Apresentar FóRMULaRIO em VIEW");
        }


    }
}
