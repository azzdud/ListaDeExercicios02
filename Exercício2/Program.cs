/*Exercício 2
 * Escreva um algoritmo que leia três valores inteiros e diferentes e
mostre-os em ordem decrescente.
*/

using System;

namespace Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double primeiroNum, segundoNum, terceiroNum;

            Console.Write("Digite o primeiro número: ");
            primeiroNum = Convert.ToDouble(Console.ReadLine());

            do 
            {
                Console.Write("Digite o Segundo número: ");
                segundoNum = Convert.ToDouble(Console.ReadLine());
            }while (primeiroNum == segundoNum);

            do
            {
                Console.Write("Digite o terceiro número: ");
                terceiroNum = Convert.ToDouble(Console.ReadLine());
            }while (primeiroNum == terceiroNum && terceiroNum == segundoNum);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" ");

            if (primeiroNum > segundoNum && segundoNum > terceiroNum)
            {
                Console.WriteLine("A ordem decrescente dos números é: " + primeiroNum + "-" + segundoNum
                    + "-" + terceiroNum + ".");
            }
            else if (primeiroNum > terceiroNum && terceiroNum > segundoNum)
            {
                Console.WriteLine("A ordem decrescente dos números é: " + primeiroNum + "-" + terceiroNum
                    + "-" + segundoNum + ".");
            }
            else if (segundoNum > primeiroNum && primeiroNum > terceiroNum)
            {
                Console.WriteLine("A ordem decrescente dos números é: " + segundoNum + "-" + primeiroNum
                    + "-" + terceiroNum + ".");
            }
            else if (segundoNum > terceiroNum && terceiroNum > primeiroNum)
            {
                Console.WriteLine("A ordem decrescente dos números é: " + segundoNum + "-" + terceiroNum
                    + "-" + primeiroNum + ".");
            }
            else if (terceiroNum > primeiroNum && primeiroNum > segundoNum)
            {
                Console.WriteLine("A ordem decrescente dos números é: " + terceiroNum + "-" + primeiroNum
                    + "-" + segundoNum + ".");
            }
            else if (terceiroNum > segundoNum && segundoNum > primeiroNum)
            {
                Console.WriteLine("A ordem decrescente dos números é: " + terceiroNum + "-" + segundoNum
                    + "-" + primeiroNum + ".");
            }

            Console.ReadLine();
        } 
    }
}
