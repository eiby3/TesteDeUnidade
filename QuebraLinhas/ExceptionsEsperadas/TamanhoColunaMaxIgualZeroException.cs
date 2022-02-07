using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuebraLinhas
{
    public class TamanhoColunaMaxIgualZeroException : Exception
    {
        public TamanhoColunaMaxIgualZeroException(string mensagem) : base(mensagem)
        {

        }
    }
}
