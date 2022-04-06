using System;

namespace DonativosJASON
{
    class Program
    {
        Controller controller = new Controller();

        static void Main(string[] args)
        {
            Console.WriteLine("Teste . NOSSO PROGRAMA ");

            Program donativos = new Program();

            donativos.controller.IniciarPrograma();

        }
    }
}
