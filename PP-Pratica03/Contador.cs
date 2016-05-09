using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elabore um programa em C# que solicita que o usuário digite um número maior
 * do que 100. O programa deverá exibir todos os números de 100 até o valor
 * digitado. Por exemplo, se o usuário digitou o número 150, o programa deverá * exibir os números de 100 a 150.
 * 
 * 
 * resultado
 * Digite um número maior que 100: 110
 * 100
 * 101
 * 102
 * 103
 * 104
 * 105
 * 106
 * 107
 * 108
 * 109
 * 110
 */

namespace PP_Pratica03
{
    class Contador
    {
        public void Contar()
        {
            Console.Write("Digite um número maior que 100: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (n < 100)
            {
                Console.WriteLine("Este número está abaixo de 100");                                
            }
            else
            {
                for (int i = 100; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
                

            
        }
        
    }
}
