using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DonativosWindowsForms.Models
{
    public class ModelDonativo
    {
        public string Nome { get; set; }
        public string Morada { get; set; }
        public string CodigoPostal { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string Telemovel { get; set; }
        public decimal Montante { get; set; }
        public string Mensagem { get; set; }

        public string JsonSerializar(ModelDonativo donativo)
        {
            return JsonConvert.SerializeObject(donativo, Formatting.Indented);
        }
    }
}
