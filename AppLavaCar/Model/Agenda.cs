using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLavaCar.Model
{
    public class Agenda
    {
        public int id { get; set; }
        public string nomeCliente { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
        public string tipoTratamento { get; set; }
        public string placaCarro { get; set; }
        public DateTime agendamento { get; set; }
        
    }
}
