using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar um programa em C# que leia vários números até ler o número 0 e calcule
 * a soma dos números lidos. (Não é para usar vetor)
 * 
 * Resultado
 * Digite um número:5
 * Digite um número:10
 * Digite um número:15
 * Digite um número:20
 * Digite um número:0
 * Números digitados: 5, 10, 15, 20, 0,
 * Quantidade de números digitados: 5
 * Soma total: 50
 */

namespace PP_Pratica03
{
    class LerSomarNumero
    {
        public void ContaSoma()
        {
            int n, i = 0, soma = 0;
            string digitados = "";
            do
            {
                Console.Write("Digite um número:");
                n = int.Parse(Console.ReadLine());
                digitados += n + ", ";
                soma += n;
                i++;
            }
            while (n != 0);
            Console.WriteLine("Números digitados: {0}", digitados);
            Console.WriteLine("Quantidade de números digitados: {0}", i);
            Console.WriteLine("Soma total: {0}", soma);
        }
    }
}
