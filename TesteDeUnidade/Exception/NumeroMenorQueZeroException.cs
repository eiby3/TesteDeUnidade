using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class NumeroMenorQueZeroException : Exception
    {
        public NumeroMenorQueZeroException(string mensagem) : base(mensagem)
        {
            
        }
    }
}
