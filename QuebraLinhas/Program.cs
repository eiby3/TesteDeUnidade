using System;
using System.Collections.Generic;
using System.Linq;

namespace QuebraLinhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuebraLinhaClass quebraLinha = new QuebraLinhaClass(2);
            string frase = "Um pequeno jabuti xereta viu dez cegonhas felizes.";
            string fraseObtida = quebraLinha.QuebradorDeLinhas(frase);
            Console.WriteLine(fraseObtida);
        }
    }
}
