using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonativosJASON
{
    class View
    {
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
            /*  [J]
             *  Esta função devia ter só texto no view e no controller é que se fazia o input,
             *  algo por exemplo:
             *  -- (no controller) --
             *  view.ApresentarBoasVindas();
             *  Resposta();
             *  LoopResposta();
             *  PreencherFormulario();  
             *  .
             *  .
             *  .
             *  public void Resposta()
             *  { 
             *      resposta=(console.ReadLine() );
             *  }
             *  public void LoopResposta()
             *  {
             *      while (resposta!= "s" || resposta!= "n" || resposta!= "N" || resposta!= "S")
             *      {
             *          view.RespostaInvalida();
             *          Resposta();
             *      }
             *  } 
             */
        {
            {
                string resposta;
                Console.WriteLine("Bem Vindo!!!"); // Podemos melhorar todas as mensagens ao utilizador, isto foi feito a pressa apenas para testar a funcionalidade!!!
                Console.WriteLine("");
                Console.WriteLine("Deseja fazer um donativo? (s/n)");
                resposta = (Console.ReadLine());


                while (resposta != "s" && resposta != "n")
                {
                    Console.WriteLine("Resposta inválida!!!");
                    Console.WriteLine("");
                    Console.WriteLine("Deseja fazer um donativo? (s/n)");
                    resposta = (Console.ReadLine());
                }

                if (resposta == "s")
                {
                    Console.WriteLine("O formulário será apresentado!!!");
                    /*
                      

                    Chamar função ApresentarFormulario!!! 
                     
                    */
                }
                else
                {
                    Console.WriteLine("Obrigado, e volte sempre!!!");
                }

            }
        }

        public void SolitarNome()
        {
            Console.WriteLine("Nome:");

        }
        public void ApresentarFormulario()
        {
            Console.WriteLine("Apresentar FoRMULaRIO em VIEW");

        }

        public void SolicitarTotaisAtualizados()
        {
            Console.WriteLine("O seu donativo " + model.Totais()); 
          
        }

        public void DonativoProcessadoSucesso()
        {
            Console.WriteLine("Processado com sucesso");
        }
    }
}
