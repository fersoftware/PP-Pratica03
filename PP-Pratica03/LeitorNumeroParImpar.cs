using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Pratica03
{
    /*
 * Elaborar um programa em C# que leia dez números e exiba quantos números * pares e quantos números ímpares foram lidos. (Não é para usar vetor)
 * 
 * Resultado
 * 1 - Digite um Número:5
 * 2 - Digite um Número:2
 * 3 - Digite um Número:3
 * 4 - Digite um Número:1
 * 5 - Digite um Número:4
 * 6 - Digite um Número:8
 * 7 - Digite um Número:9
 * 8 - Digite um Número:2
 * 9 - Digite um Número:4
 * 10 - Digite um Número:6
 * 
 * Números digitados:
 * Impar: 5, 3, 1, 9,
 * Par: 2, 4, 8, 2, 4, 6,
 */
    class LeitorNumeroParImpar
    {
        public void LeiaImparPar()
        {
            int n;
            string impar = "", par = "";
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} - Digite um Número:", i+1);
                n = int.Parse(Console.ReadLine());

                if(n %2 == 0)
                {
                    par += n + ", ";
                }
                else
                {
                    impar += n + ", ";
                }
            }
            Console.WriteLine("Números digitados:");
            Console.WriteLine("Impar: {0}", impar);
            Console.WriteLine("Par: {0}", par);
        }
    }
}
