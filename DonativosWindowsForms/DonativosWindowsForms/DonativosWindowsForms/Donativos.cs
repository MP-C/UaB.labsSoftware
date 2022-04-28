using DonativosWindowsForms.Forms;
using DonativosWindowsForms.Controllers;

namespace DonativosWindowsForms
{
    public class Donativos
    {

        static Controller controller;

        [STAThread]
        static void Main()
        {
            controller = new Controller();
            controller.IniciarPrograma();
              
        }
    }
}