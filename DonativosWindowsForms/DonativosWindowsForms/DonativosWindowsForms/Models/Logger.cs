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

            public string Tipo
            {
                get
                {
                    string[] partes = item.Split(new[] { separador.ToString() }, StringSplitOptions.None);
                    if (partes.Length < 1)
                        return "Indefinido";
                    else
                        return partes[0];
                }
                set
                {
                    string[] partes = item.Split(new[] { separador.ToString() }, StringSplitOptions.None);
                    if (partes.Length < 2)
                    {
                        Array.Resize(ref partes, 2);
                        partes[1] = "";
                    }
                    partes[0] = value;
                    item = partes[0] + separador + partes[1];
                }
            }
            public char Separador { get => separador; set => separador = value; }
            public string Mensagem
            {
                get
                {
                    string[] partes = item.Split(new[] { separador.ToString() }, StringSplitOptions.None);
                    if (partes.Length < 2)
                        return "";
                    else
                        return partes[1];
                }
                set
                {
                    string[] partes = item.Split(new[] { separador.ToString() }, StringSplitOptions.None);
                    if (partes.Length < 1)
                    {
                        Array.Resize(ref partes, 2);
                        partes[0] = "Indefinido";
                    }
                    if (partes.Length < 2)
                        Array.Resize(ref partes, 2);
                    partes[1] = value;
                    item = partes[0] + separador + partes[1];
                }
            }

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

            MessageBox.Show("teste");
            
            // Esta a dar erro, corrigir Null Exception
            //NotificarLogAlterado();
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
