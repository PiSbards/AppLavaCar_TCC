using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLavaCar.Controller
{
    public class VerificacaoCpfCnpj
    {
        public bool ValidarCPF(string cpf)
        {            
            cpf = new string(cpf.Where(char.IsDigit).ToArray());
            
            if (cpf.Length != 11)
                return false;            

            bool allEqual = cpf.Distinct().Count() == 1;
            if (allEqual)
                return false;
            
            int[] multipliers1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multipliers2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            
            int sum1 = 0;
            for (int i = 0; i < 9; i++)
            {
                sum1 += int.Parse(cpf[i].ToString()) * multipliers1[i];
            }
            int remainder1 = sum1 % 11;
            int digit1 = remainder1 < 2 ? 0 : 11 - remainder1;
            
            int sum2 = 0;
            for (int i = 0; i < 9; i++)
            {
                sum2 += int.Parse(cpf[i].ToString()) * multipliers2[i];
            }
            sum2 += digit1 * multipliers2[9];
            int remainder2 = sum2 % 11;
            int digit2 = remainder2 < 2 ? 0 : 11 - remainder2;

            
            if (int.Parse(cpf[9].ToString()) != digit1 || int.Parse(cpf[10].ToString()) != digit2)
                return false;

            return true;
        }
        public bool ValidarCNPJ(string cnpj)
        {            
            cnpj = new string(cnpj.Where(char.IsDigit).ToArray());
            
            if (cnpj.Length != 14)
                return false;
            
            int[] multipliers1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multipliers2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            
            int sum1 = 0;
            for (int i = 0; i < 12; i++)
            {
                sum1 += int.Parse(cnpj[i].ToString()) * multipliers1[i];
            }
            int remainder1 = sum1 % 11;
            int digit1 = remainder1 < 2 ? 0 : 11 - remainder1;
            
            int sum2 = 0;
            for (int i = 0; i < 13; i++)
            {
                sum2 += int.Parse(cnpj[i].ToString()) * multipliers2[i];
            }
            int remainder2 = sum2 % 11;
            int digit2 = remainder2 < 2 ? 0 : 11 - remainder2;
            
            if (int.Parse(cnpj[12].ToString()) != digit1 || int.Parse(cnpj[13].ToString()) != digit2)
                return false;
            
            return true;
        }

    }
}
