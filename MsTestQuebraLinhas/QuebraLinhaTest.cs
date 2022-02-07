using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuebraLinhas;
using System;

namespace MsTestQuebraLinhas
{
    [TestClass]
    public class QuebraLinhaTest
    {
        [TestMethod]
        public void RetornaFraseQuebrandoLinhaComMaximo20Colunas()
        {
            string frase = "Um pequeno jabuti xereta viu dez cegonhas felizes.";
            string retornoEsperado = "Um pequeno jabuti \n\rxereta viu dez \n\rcegonhas felizes.";


            QuebraLinhaClass quebraLinhas = new QuebraLinhaClass();
            string retornoObtido = quebraLinhas.QuebradorDeLinhas(frase);

            Assert.AreEqual(retornoEsperado, retornoObtido);
        }
        [TestMethod]
        public void RetornaFraseQuebrandoLinhaComMaximo15Colunas()
        {
            string frase = "Um pequeno jabuti xereta viu dez cegonhas felizes.";
            string retornoEsperado = "Um pequeno \n\rjabuti xereta \n\rviu dez \n\rcegonhas \n\rfelizes.";


            QuebraLinhaClass quebraLinhas = new QuebraLinhaClass(15);
            string retornoObtido = quebraLinhas.QuebradorDeLinhas(frase);

            Assert.AreEqual(retornoEsperado, retornoObtido);
        }
        [TestMethod]
        [ExpectedException(typeof(TamanhoColunaMaxIgualZeroException))]        
        public void RetornarExceptionComLinhaDeMaximoZeroColunas()
        {
            string frase = "Um pequeno jabuti xereta viu dez cegonhas felizes.";            
            int numeroMaxColunas = 0;

            QuebraLinhaClass quebraLinhas = new QuebraLinhaClass(numeroMaxColunas);
            string retornoObtido = quebraLinhas.QuebradorDeLinhas(frase);                       
        }
        [TestMethod]
        [ExpectedException(typeof(TamanhoColunaMaxMenorQueZeroException))]        
        public void RetornarExceptionComLinhaDeMaximoMenorQueZeroColunas()
        {
            string frase = "Um pequeno jabuti xereta viu dez cegonhas felizes.";
            int numeroMaxColunas = -1;

            QuebraLinhaClass quebraLinhas = new QuebraLinhaClass(numeroMaxColunas);
            string retornoObtido = quebraLinhas.QuebradorDeLinhas(frase);
        }

        [TestMethod]
        [ExpectedException(typeof(ColunasMenorQueTextoException))]
        public void RetornarExceptionCasoMaximoDeColunasForMenorQueTexto()
        {
            string frase = "Um pequeno jabuti xereta viu dez cegonhas felizes.";
            int numeroMaxColunas = 2;            

            QuebraLinhaClass quebraLinhas = new QuebraLinhaClass(numeroMaxColunas);
            string retornoObtido = quebraLinhas.QuebradorDeLinhas(frase);

        }
    }
}
