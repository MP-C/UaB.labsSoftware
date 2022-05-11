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
        private ViewFormulario view;
        private Logger modelLog;
        private string filePath = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "Database\\Database.json");

        public delegate void NotificacaoLogAlterado();
        public event NotificacaoLogAlterado NotificarLogAlterado;

        public Model(ViewFormulario v)
        {
            view = v;
            modelLog = new Logger();
            modelLog.NotificarLogAlterado += LancarNotificarLogAlterado;
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

            var jsonData = File.ReadAllText(filePath);
            ListDonativos json = JsonConvert.DeserializeObject<ListDonativos>(jsonData);

            json.donativos.Add(donativo);

            jsonData = JsonConvert.SerializeObject(json, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);
            
            ViewDonativos respostaFinal = new ViewDonativos(this);
            respostaFinal.ActivarInterface(Totais(), donativo.Montante);
                
          
        }

        public decimal Totais()
        {
            var jsonData = File.ReadAllText(filePath);
            ListDonativos json = JsonConvert.DeserializeObject<ListDonativos>(jsonData);
            decimal total = json.donativos.Sum(x => x.Montante);
            return total;
        }

        private void LancarNotificarLogAlterado()
        {
            NotificarLogAlterado();
        }
    }
}
