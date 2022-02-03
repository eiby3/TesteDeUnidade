using System;
using System.Collections.Generic;
using System.Linq;

namespace QuebraLinhas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = "Um pequeno jabuti xereta viu dez cegonhas felizes.";
            string[] fraseseparada = frase.Split();
            string palavras;
            string[] letras;
            string espaco = " ";
            List<string[]> listaComAsPalavrasArray = new List<string[]>();

            for (int i = 0; i < fraseseparada.Length; i++)
            {
                palavras = fraseseparada[i];
                letras = palavras.ToCharArray().Select(c => c.ToString()).ToArray();
                listaComAsPalavrasArray.Add(letras);
                listaComAsPalavrasArray.Add(espaco.ToCharArray().Select(c => c.ToString()).ToArray());
            }

            string linha = null;

            int numeroMaxColunas = 20;
            int contador = 0;
            foreach (var arrays in listaComAsPalavrasArray)
            {

                for (int i = 0; i < arrays.Length; i++)
                {
                    if (contador == numeroMaxColunas && arrays[i] != " ")
                    {
                        while (linha[linha.Length - 1] != 32)
                        {
                            linha = linha.Remove(linha.Length - 1);
                            i--;
                        }                       

                    }
                    if (contador == numeroMaxColunas)
                    {
                        linha += "\n\r";
                        contador = 0;
                    }
                    linha += arrays[i];
                    contador++;
                }

            }
            Console.WriteLine(linha);
        }
    }
}
