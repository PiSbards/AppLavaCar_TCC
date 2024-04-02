using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLavaCar.Model
{
    public class Funcionario
    {
        public int id { get; set; }        
        public string nome { get; set; }
        public int cpf { get; set; }
        public string senha { get; set; }
        public string email { get; set; }
        public string gerente { get; set; }
    }
}
