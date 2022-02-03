using FizzBuzz;
using NUnit.Framework;

namespace TesteFizzBuzz
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
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
        [Test]
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
        [Test]
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
        [Test]
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
    }
}