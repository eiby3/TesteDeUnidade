using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string VerificarNumeros(int numero)
        {
            if (numero % 3 == 0 && numero % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (numero % 3 == 0)
            {
                return "Fizz";
            }
            else if (numero % 5 == 0)
            {
                return "Buzz";
            }
            else return numero.ToString();
        }
    }
}
