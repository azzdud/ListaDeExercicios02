/* Exercício 1
 * Faça um algoritmo que leia os valores A, B, C e imprima na tela se a 
soma de A + B é menor que C.
*/

using System;

namespace Exercício1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorA, valorB, valorC;

            Console.Write("Escreva o valor A: ");
            valorA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Agora, o valor B: ");
            valorB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Em seguida, escreva o valor C: ");
            valorC = Convert.ToDouble(Console.ReadLine());
            
            if(valorA + valorB < valorC)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("\nA soma de " + valorA + " (Valor A) e " + valorB +
                    " (Valor B) é MAIOR do que " + valorC + "!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("\nA soma de " + valorA + " (Valor A) e " + valorB + 
                   " (Valor B) é MENOR do que " + valorC + "!");
            }
            Console.ReadLine();
        }
    }
}
