using System;
using System.Collections.Generic;
using System.Linq;

namespace QuebraLinhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuebraLinhaClass quebraLinha = new QuebraLinhaClass(40);
            string frase = "Hoje é um dia especial para mim.";
            string fraseObtida = quebraLinha.QuebradorDeLinhas(frase);
            Console.WriteLine(fraseObtida);
        }
    }
}
