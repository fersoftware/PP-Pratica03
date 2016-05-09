using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar um programa em C# que apresente todos os números divisíveis por 4
 * que sejam menores que 200.
 * 
 */

namespace PP_Pratica03
{
    class DivisivelMenor100
    {
        public void DivMenor100()
        {
            for (int i = 200; i >= 0; i--)
            {
                if(i %4==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
