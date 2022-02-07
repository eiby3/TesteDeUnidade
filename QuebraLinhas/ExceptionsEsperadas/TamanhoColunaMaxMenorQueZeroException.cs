using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuebraLinhas
{
    public class TamanhoColunaMaxMenorQueZeroException : Exception
    {
        public TamanhoColunaMaxMenorQueZeroException(string mensagem) : base(mensagem)
        {

        }
    }
}
