using System;

namespace Exercicio6
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("Insere um número inteiro");
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Número inserido: {i}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: não é um inteiro válido");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Erro: valor fora dos limites de Int32");
            }
            catch (Exception e)
            {
                Console.WriteLine(
                    $"Ocorreu o seguinte problema: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Obrigado por ter utilizado este programa!");
            }
        }
    }
}
