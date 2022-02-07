using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzClass fizzBuzz = new FizzBuzzClass();
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzz.VerificarNumeros(i));
            }                          
        }
    }
}
