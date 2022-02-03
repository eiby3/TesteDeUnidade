using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzClass
    {
        public string VerificarNumeros(int numero)
        {
            if (numero == 0)
            {
                throw new DivideByZeroException(nameof(numero));
            }
            if (numero < 0)
            {
                throw new NumeroMenorQueZeroException("Valor negativo não permitido");
            }
            else if (numero % 3 == 0 && numero % 5 == 0)
            {
                return "fizzbuzz";
            }
            else if (numero % 3 == 0)
            {
                return "fizz";
            }
            else if (numero % 5 == 0)
            {
                return "buzz";
            }
            
            else return numero.ToString();


        }
    }
}
