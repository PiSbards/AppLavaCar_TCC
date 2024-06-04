using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLavaCar.Controller
{
    public class Cripto
    {
        public string Base64Encode(string textoencode)
        {
            var textoencodebytes = System.Text.Encoding.UTF8.GetBytes(textoencode);
            return System.Convert.ToBase64String(textoencodebytes);
        }        
        public string Base64Decode(string textodecode)
        {
            var textodecodebytes = System.Convert.FromBase64String(textodecode);
            return System.Text.Encoding.UTF8.GetString(textodecodebytes);
        }
    }
}
