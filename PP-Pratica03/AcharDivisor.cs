using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar um programa em C# que leia um número e exiba os seus divisores.
 * Exemplos:
 * Se o número lido for 3, seus divisores são 1 e 3. * Se o número lido for 6, seus divisores são 1, 2, 3 e 6.
 */

namespace PP_Pratica03
{
    class AcharDivisor
    {
        public void Divisor()
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            string divisivel = "";

            for (int i = 1; i <= 10; i++)
            {
                if (num % i == 0) divisivel += i + ",";
            }
            Console.WriteLine("O número {0} é divisível por {1}", num, divisivel);
        }
    }
}
