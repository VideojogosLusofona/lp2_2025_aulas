using System;

namespace Exercicio3
{
    public class Program
    {
        private static void Main()
        {
            int i;
            Console.WriteLine("Insere um número inteiro");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Número inserido: {i}");
        }
    }
}
