using System;
using System.IO;//para o File.Exists funcionar
using Newtonsoft.Json;
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
        //public string Nome { get; set; }

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
            // fileName = %USER%\source\repos\UaB.labsSoftware\DonativosJASON\donativos.json
            string fileName = (Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\source\repos\UaB.labsSoftware\DonativosJASON\donativos.json");
            //string nomeTeste = nome;
            //Verificação se ficheiro existe
            if (!File.Exists(fileName))
            {
                //se não existe criar o ficheiro
                using (File.Create(fileName));
            }

            Donativo donativo = new Donativo();
            donativo.Nome = nome;

            String existingFileContents = File.ReadAllText(fileName);

            
            FicheiroDonativos json = JsonConvert.DeserializeObject<FicheiroDonativos>(existingFileContents);//verificar porque retorna null

            json.donativos.Add(donativo);

            controller.DonativoPronto();

        }
        public decimal Totais()
        {
            //Ler o ficheiro Json 
            return 0; //Retornar o total de donativos, consultar o ficheiro Json
        }


    }
}
