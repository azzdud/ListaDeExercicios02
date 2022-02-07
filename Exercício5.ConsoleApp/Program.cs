/*Exercício 5
 * Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem 
iguais deverá se somar os dois, caso contrário multiplique A por B.
Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma 
variável C e mostrar seu conteúdo na tela*/

using System;

namespace Exercício5.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB, valorC;

            Console.Write("Digite o Valor A: ");
            valorA = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Digite o Valor B: ");
            valorB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Green;

            if (valorA == valorB)
            {
                valorC = (valorA + valorB);
                Console.WriteLine(valorA + " somado com " + valorB + " é igual a: " + valorC);
            }
            else
            {
                valorC = (valorA * valorB);
                Console.WriteLine(valorA + " multiplicado por " + valorB + " é igual a: " + valorC);
            }
                        
            Console.ReadLine();
        }
    }
}
