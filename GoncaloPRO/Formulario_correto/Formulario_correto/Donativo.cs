using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_correto
{
    internal class Donativo
    {
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string CodigoPostal { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string Telemovel { get; set; }
        public float Valor { get; set; }
        public string Anonimato { get; set; }
        public string Mensagem { get; set; }

        public string JsonSerializar(Donativo donativo)
        {
            return JsonConvert.SerializeObject(donativo, Formatting.Indented);
        }
    }
}
