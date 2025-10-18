using System;

namespace Exercicio4
{
    public class Program
    {
        private static void Main()
        {
            int i = 0;
            Console.WriteLine("Insere um número inteiro");
            try
            {
                i = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(
                    $"Ocorreu o seguinte problema: {e.Message}");
            }
            Console.WriteLine($"Número inserido: {i}");
        }
    }
}
