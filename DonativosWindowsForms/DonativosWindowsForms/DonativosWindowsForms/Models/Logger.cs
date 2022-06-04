using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DonativosWindowsForms.Models.Logger;

namespace DonativosWindowsForms.Models
{
    public class Logger
    {
        public interface ILogItem
        {
            string Tipo { get; }
            string Mensagem { get; }
        }


        internal class LogItem : ILogItem
        {
            private string item = "";
            private char separador = ';';

            public string Tipo { get; set; }
            
            public string Mensagem { get; set; }

            public LogItem() { Tipo = "Indefinido"; Mensagem = ""; }
        }

        private List<LogItem> log;

        public Logger()
        {
            log = new List<LogItem>();
        }

        public event Model.NotificacaoLogAlterado NotificarLogAlterado;


        public void RegistarErro(string tipo, string mensagem)
        {
            LogItem item = new LogItem();
            item.Tipo = tipo;
            item.Mensagem = mensagem;
            log.Add(item);
        }
        

        public List<ILogItem> SolicitarLog()
        {
            List<ILogItem> listalog = new List<ILogItem>();
            foreach (ILogItem item in log)
            {
                listalog.Add(item);
            }
            return listalog;
        }
    }

}
