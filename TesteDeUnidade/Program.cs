using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(fizzBuzz.VerificarNumeros(i));
            }
        }
    }
}
