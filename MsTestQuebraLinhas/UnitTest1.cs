using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuebraLinhas;
using System;

namespace MsTestQuebraLinhas
{
    [TestClass]
    public class UnitTest1
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
            string frase = "Hoje é um dia especial para mim.";
            string retornoEsperado = "Hoje é um dia \n\respecial para \n\rmim.";


            QuebraLinhaClass quebraLinhas = new QuebraLinhaClass(15);
            string retornoObtido = quebraLinhas.QuebradorDeLinhas(frase);

            Assert.AreEqual(retornoEsperado, retornoObtido);
        }
        [TestMethod]
        [ExpectedException(typeof(TamanhoColunaMaxIgualZeroException))]        
        public void RetornarExceptionComLinhaDeMaximoZeroColunas()
        {
            string frase = "Hoje é um dia especial para mim.";            
            int numeroMaxColunas = 0;

            QuebraLinhaClass quebraLinhas = new QuebraLinhaClass(numeroMaxColunas);
            string retornoObtido = quebraLinhas.QuebradorDeLinhas(frase);                       
        }
        [TestMethod]
        [ExpectedException(typeof(TamanhoColunaMaxMenorQueZeroException))]        
        public void RetornarExceptionComLinhaDeMaximoMenorQueZeroColunas()
        {
            string frase = "Hoje é um dia especial para mim.";
            int numeroMaxColunas = -1;

            QuebraLinhaClass quebraLinhas = new QuebraLinhaClass(numeroMaxColunas);
            string retornoObtido = quebraLinhas.QuebradorDeLinhas(frase);
        }

        [TestMethod]
        public void RetornarProprioTextoTextoCasoMaximoDeColunasForMaiorQueTexto()
        {
            string frase = "Hoje é um dia especial para mim.";
            int numeroMaxColunas = 40;
            string retornoEsperado = "Hoje é um dia especial para mim.";

            QuebraLinhaClass quebraLinhas = new QuebraLinhaClass(numeroMaxColunas);
            string retornoObtido = quebraLinhas.QuebradorDeLinhas(frase);

            Assert.AreEqual(retornoEsperado, retornoObtido);
        }
    }
}
