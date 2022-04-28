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
        String nome;
        
        public void IniciarPrograma()
        {
            model = new Model(this, view);
            view = new View(this, model);

            view.ApresentarBoasVindas();
            PreencherFormulario();
            view.SolicitarTotaisAtualizados();

        }

        public void PreencherFormulario()
        {
            //Nome, NIB, Morada, ID, Donativo, Valor, Kilos, Mensagem, Anonimato.
            view.SolitarNome();
            nome = Console.ReadLine();
            //Continuar a pedir os dados do Formulário
            model.ProcessarDonativo(nome);
        }

        public void DonativoPronto()
        {
            view.DonativoProcessadoSucesso();
            Console.ReadLine();
        }
        

    }
}
