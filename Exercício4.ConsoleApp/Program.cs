/* Exercício 4
 * Faça um algoritmo para receber um número qualquer e informar na tela se 
é par ou ímpar.*/

using System;

namespace Exercício4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resto;
            do
            {
                Console.Write("Digite o número para saber se é ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("PAR");
                Console.ResetColor();
                Console.Write(" ou ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("IMPAR");
                Console.ResetColor();
                Console.Write(": ");
                numero = Convert.ToInt32(Console.ReadLine());

                resto = numero % 2;

                if (resto == 0)
                {
                    Console.Write("\nEste número é ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("PAR");
                }
                else
                {
                    Console.Write("\nEste número é ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("IMPAR");                    
                }
                Console.WriteLine(" ");
                Console.ResetColor ();
                Console.WriteLine(" ");

            } while (true);

    {

            }
            Console.ReadLine();
        }
    }
}
