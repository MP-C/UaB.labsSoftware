using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DonativosWindowsForms.Views;
using Newtonsoft.Json;

namespace DonativosWindowsForms.Models
{
    public class Model
    {
        private ViewDonativos view;
        private string filePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Database\\Database.json"); 

        public Model(ViewDonativos v)
        {
            view = v;
        }

        public void ProcessarDonativo(string nome, string morada, string codigopostal, string cidade, string pais, string telemovel, decimal montante, string mensagem)
        {
            ModelDonativo donativo = new ModelDonativo();
            donativo.Nome = nome;
            donativo.Morada = morada;
            donativo.CodigoPostal = codigopostal;
            donativo.Cidade = cidade;
            donativo.Pais = pais;
            donativo.Telemovel = telemovel;
            donativo.Montante = montante;
            donativo.Mensagem = mensagem;

            string text = JsonConvert.SerializeObject(donativo);


            string fileName = File.ReadAllText(filePath);
            ListDonativos json = JsonConvert.DeserializeObject<ListDonativos>(fileName);
            json.donativos.Add(donativo);

            ViewDonativos respostaFinal = new ViewDonativos(this);
            respostaFinal.ActivarInterface();
                
          
        }

        public decimal Totais()
        {
            //decimal total = donativos.Sum(x => x.Montante);
            decimal total = 0;
            return total;
        }
    }
}
