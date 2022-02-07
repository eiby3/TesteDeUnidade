using FizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MsTestFizzBuzz
{
    [TestClass]
    public class FizzBuzzTeste
    {
        [TestMethod]
        public void RetornaBuzzMultiploDeCinco()
        {
            string valorEsperado = "buzz";
            FizzBuzzClass fizzBuzz = new FizzBuzzClass();

            int numero = 5;
            string valorObtido = fizzBuzz.VerificarNumeros(numero);
            Assert.AreEqual(valorEsperado, valorObtido);

            numero = 10;
            valorObtido = fizzBuzz.VerificarNumeros(numero);
            Assert.AreEqual(valorEsperado, valorObtido);

            numero = 20;
            valorObtido = fizzBuzz.VerificarNumeros(numero);
            Assert.AreEqual(valorEsperado, valorObtido);
        }
        [TestMethod]
        public void RetornaBuzzMultiploDeTres()
        {
            string valorEsperado = "fizz";
            FizzBuzzClass fizzBuzz = new FizzBuzzClass();

            int numero = 3;
            string valorObtido = fizzBuzz.VerificarNumeros(numero);
            Assert.AreEqual(valorEsperado, valorObtido);

            numero = 6;
            valorObtido = fizzBuzz.VerificarNumeros(numero);
            Assert.AreEqual(valorEsperado, valorObtido);

            numero = 9;
            valorObtido = fizzBuzz.VerificarNumeros(numero);
            Assert.AreEqual(valorEsperado, valorObtido);
        }
        [TestMethod]
        public void RetornaBuzzMultiploDeTresECinco()
        {
            string valorEsperado = "fizzbuzz";
            FizzBuzzClass fizzBuzz = new FizzBuzzClass();

            int numero = 15;
            string valorObtido = fizzBuzz.VerificarNumeros(numero);
            Assert.AreEqual(valorEsperado, valorObtido);

            numero = 30;
            valorObtido = fizzBuzz.VerificarNumeros(numero);
            Assert.AreEqual(valorEsperado, valorObtido);

            numero = 45;
            valorObtido = fizzBuzz.VerificarNumeros(numero);
            Assert.AreEqual(valorEsperado, valorObtido);
        }
        [TestMethod]
        public void RetornaProprioNumero()
        {

            FizzBuzzClass fizzBuzz = new FizzBuzzClass();

            int numero = 1;
            string valorEsperado = numero.ToString();
            string valorObtido = fizzBuzz.VerificarNumeros(numero);
            Assert.AreEqual(valorEsperado, valorObtido);

            numero = 2;
            valorObtido = fizzBuzz.VerificarNumeros(numero);
            valorEsperado = numero.ToString();
            Assert.AreEqual(valorEsperado, valorObtido);

            numero = 4;
            valorObtido = fizzBuzz.VerificarNumeros(numero);
            valorEsperado = numero.ToString();
            Assert.AreEqual(valorEsperado, valorObtido);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void RetornarExceptionNumeroIgualZero()
        {
            FizzBuzzClass fizzBuzz = new FizzBuzzClass();
            string valorObtido = fizzBuzz.VerificarNumeros(0);
        }
        [TestMethod]
        [ExpectedException(typeof(NumeroMenorQueZeroException))]
        public void RetornarExceptionMenorQueZero()
        {
            FizzBuzzClass fizzBuzz = new FizzBuzzClass();
            string valorObtido = fizzBuzz.VerificarNumeros(-1);
        }
    }
}
