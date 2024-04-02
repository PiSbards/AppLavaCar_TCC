using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLavaCar.Model
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int cpf { get; set; }
        public string telefone { get; set; }
        public string placaCarro { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }        
    }
}
