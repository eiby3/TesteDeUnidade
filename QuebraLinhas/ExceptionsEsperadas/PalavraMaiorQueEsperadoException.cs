using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuebraLinhas
{
    public class PalavraMaiorQueEsperadoException : Exception
    {
        public PalavraMaiorQueEsperadoException(string mensagem) : base(mensagem)
        {

        }
    }
}
