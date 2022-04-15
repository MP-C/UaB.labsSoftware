using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonativosJASON
{
    class Model
    {    
        private Controller controller; //variaveis da class que apenas se podem usar aqui
        private View view; //variaveis da class
        public string Nome { get; set; }

        public Model (Controller c, View v)
        // constructor, serve para se poder usar novas variaveis e
        // outras class existentes fora desta
        // para criar objeto
        {
            controller = c;
            view = v;
        }

        public void ProcessarDonativo(string nome)
        {
            //Criar o código para guardar no ficheiro Jason
            controller.DonativoPronto();

        }
        public decimal Totais()
        {
            //Ler o ficheiro Json 
            return 0; //Retornar o total de donativos, consultar o ficheiro Json
        }


    }
}
