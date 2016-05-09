using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar um programa em C# que calcule e exiba a soma de 1 até 500 (inclusive). *  * Resultado * soma de 0+1=1 ... soma de 499+1=500*/

namespace PP_Pratica03
{
    class Conta500
    {
        public void contar()
        {
            int n = 0;
            while (n <500)
            {                
                Console.WriteLine("soma de {0}+{1}={2}", n, 1, n+1);
                n += 1;
            }
        }
    }
}
