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
        /*  [J]
         *  No diagrama antes de PreencherFormulario() há um ApresentarFormulario()
         *  poderia ser algo como:
         *  - - (na view) - - 
         *  ApresentarFormulário()
         *  {
         *     controller.PreencherFormulario()
         *     //depois quando acabar
         *     
         *     
         *  }
         *  
         *  - - - -
         *  
         *  - - (no controller) - -
         *  public void PreencherFormulario() 
         *  {
         *      //adicionar antes da linha 57
         *      view.ApresentarBotaoAguarde();
         *      
         *  }
         * 
         * 
         */
        public void PreencherFormulario()
        {
            //Nome, NIB, Morada, ID, Donativo, Valor, Kilos, Mensagem, Anonimato.
            view.SolitarNome();
            nome = Console.ReadLine();
            /*  [J]
             *  view.ApresentarBotaoAguarde();
             */
            //Continuar a pedir os dados do Formulário
            model.ProcessarDonativo(nome);
        }

        public void DonativoPronto()
        {
            Console.WriteLine("Processado com sucesso"); // Verificar se é preciso criar um estado
            /*  [J]
             *  podia-se criar um botão aguarde que faria aparecer uns pontinhos à frente
             *  que faria o programa mais parecido com o do exemplo do prof QuartoChines.sln
             *  e que terminaria quando uma variavel mudasse
             *  exemplo
             *  
             *  Console.Write("Aguarde");
             *  while (!model.variavel)
             *  {
             *      Console.Write(".");
             *      model.EstadodeVariavel();
             *  }
             *  
             *  A questão é se isto é oportuno e se podemos implementar no código,
             *  teria de ficar entre o ProcessarDonativo() e DonativoPronto() que terminava o ciclo.
             *  
             */
        }
        

    }
}
