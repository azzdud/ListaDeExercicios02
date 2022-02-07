/*Exercício 3
 * O IMC – Índice de Massa Corporal é um critério da Organização Mundial 
de Saúde para dar uma indicação sobre a condição de peso de uma pessoa 
adulta
• A fórmula é IMC = peso / (altura)²
• Elabore um algoritmo que leia o peso e a altura de um adulto e mostre 
sua condição de acordo com a tabela abaixo.

IMC em adultos Condição
Abaixo de 18,5 Abaixo do peso
Entre 18,5 e 25 Peso normal
Entre 25 e 30 Acima do peso
Acima de 30 obeso
*/

using System;

namespace Exercício3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do {
                double imc, peso, altura;

                Console.Write("Digite seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite sua altura: ");
                altura = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine(" ");

                imc = peso / (altura * altura);

                if (imc < 18.5)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Segundo o cálculo IMC, você está abaixo do peso!");
                }
                else if (imc > 18.5 && imc < 25)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Segundo o cálculo IMC, você está no peso ideal!");
                }
                else if (imc > 25 && imc < 30)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Segundo o cálculo IMC, você está acima do peso!");
                }
                else if (imc > 30)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Segundo o cálculo IMC, você está obeso!");
                }
                Console.ResetColor();
                Console.WriteLine(" ");
            }while (true);
            Console.ReadLine();          
        }
    }
}
