using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuebraLinhas
{
    public class QuebraLinhaClass
    {
        private List<string[]> listaComAsPalavrasArray = new List<string[]>();
        private int _numeroMaxColunas { get; set; }
        private int quantasLetrasForamRemovidas { get; set; }

        public QuebraLinhaClass()
        {
            _numeroMaxColunas = 20;
        }
        public QuebraLinhaClass(int numeroMaxColunas)
        {
            _numeroMaxColunas = numeroMaxColunas;
        }
        private void SeparadorDeLetras(string frase)
        {
            string[] fraseseparada = frase.Split();
            VerificarTamanhoPalavras(fraseseparada);
            string palavras;
            string[] letras;
            string espaco = " ";
            for (int i = 0; i < fraseseparada.Length; i++)
            {
                palavras = fraseseparada[i];
                letras = palavras.ToCharArray().Select(c => c.ToString()).ToArray();
                listaComAsPalavrasArray.Add(letras);
                listaComAsPalavrasArray.Add(espaco.ToCharArray().Select(c => c.ToString()).ToArray());
            }
        }
        private string RemovedorUltimaLetra(string linha)
        {
            int espacoASCII = 32;
            int quantasLetrasForamRemovidas = 0;
            while (linha[linha.Length - 1] != espacoASCII)
            {
                linha = linha.Remove(linha.Length - 1);
                quantasLetrasForamRemovidas++;
            }
            return linha;
        }
        public string QuebradorDeLinhas(string frase)
        {
            VerificarTamanhoColuna(_numeroMaxColunas);
            SeparadorDeLetras(frase);


            string linha = null;
            int contador = 0;
            foreach (var arrays in listaComAsPalavrasArray)
            {
                for (int i = 0; i < arrays.Length; i++)
                {
                    if (contador == _numeroMaxColunas && arrays[i] != " ")
                    {
                        linha = RemovedorUltimaLetra(linha);
                        i = quantasLetrasForamRemovidas;

                    }
                    if (contador == _numeroMaxColunas)
                    {
                        linha += "\n\r";
                        contador = 0;
                    }
                    linha += arrays[i];
                    contador++;
                }
            }
            linha = RemoverUltimoEspaco(linha);
            return linha;
        }



        private void VerificarTamanhoColuna(int numeroColunas)
        {
            if (numeroColunas == 0)
            {
                throw new TamanhoColunaMaxIgualZeroException(nameof(numeroColunas));
            }
            else if (numeroColunas < 0)
            {
                throw new TamanhoColunaMaxMenorQueZeroException(nameof(numeroColunas));
            }
        }

        private void VerificarTamanhoPalavras(string[] palavras)
        {
            if (palavras.Length > _numeroMaxColunas)
            {
                throw new ColunasMenorQueTextoException("Tamanho da frase ultrapassou o numero maximo de colunas");
            }

        }
        private string RemoverUltimoEspaco(string linha)
        {
            linha = linha.Remove(linha.Length - 1);

            return linha;
        }
    }
}
