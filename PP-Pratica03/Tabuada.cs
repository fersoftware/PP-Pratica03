using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar um programa em C# que leia um número e exiba a sua tabuada. Por
 * exemplo, se o número lido for 2, o programa deverá exibir:
 * 2 x 1 = 2
 * 2 x 2 = 4
 * 2 x 3 = 6
 * 2 x 4 = 8
 * 2 x 5 = 10
 * 2 x 6 = 12
 * 2 x 7 = 14
 * 2 x 8 = 16
 * 2 x 9 = 18
 * 2 x 10 = 20 
 */

namespace PP_Pratica03
{
    class Tabuada
    {
        public void MontaTabuada()
        {
            Console.Write("Digite um Número: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}",n,i, n * i);
            }
        }
    }
}
