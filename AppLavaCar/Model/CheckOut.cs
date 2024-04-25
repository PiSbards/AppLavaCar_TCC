using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLavaCar.Model
{
    public class CheckOut
    {
        public int id { get; set; }
        public string nomeCliente { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }        
        public string tipoTratamento { get; set; }
        public string placaCarro { get; set; }
        public DateTime agendamento { get; set; }
        public string defeitos { get; set; }
        public string clienteCiente { get; set; }
        public string pagamento { get; set; }
        public string observacao { get; set; }
        public string imagem1 { get; set; }
        public string imagem2 { get; set; }
        public string imagem3 { get; set; }
        public string imagem4 { get; set; }
        public string imagem5 { get; set; }
    }
}
