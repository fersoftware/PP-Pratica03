using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar um programa em C# que apresente no final o somatório dos valores
 * pares existentes na faixa de 1 até 400.
 * 
 * Resultado é 40200;
 */

namespace PP_Pratica03
{
    class SomaPares
    {
        public void Soma_Pares()
        {
            int i = 1, soma = 0;
            while (i <= 400)
            {
                if(i %2==0 )
                {
                    soma += i;                   
                }
                i++;
            }
            Console.WriteLine(soma);
        }
    }
}
