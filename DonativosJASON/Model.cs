using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonativosJASON
{
    class Model
    {
        /// <summary>
        /// aqui vai contar com toda a informação do formulario - Proxima etapa
        /// </summary>
        
        private Controller controller; //variaveis da class que apenas se podem usar aqui
        private View view; //variaveis da class
        public string Nome(get, set;);

        public Model (Controller c, View v)
        // constructor, serve para se poder usar novas variaveis e
        // outras class existentes fora desta
        // para criar objeto
        {
            controller = c;
            view = v;
        }



    }
}
