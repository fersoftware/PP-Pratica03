using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar um programa em C# que efetue a leitura sucessiva de valores numéricos
 * e apresente no final o somatório, a média e o total de valores lidos. O programa
 * deve fazer as leituras dos valores enquanto o usuário estiver fornecendo valores
 * positivos. Ou seja, o programa deve parar quando o usuário fornecer um valor
 * negativo (menor que zero).
 */

namespace PP_Pratica03
{
    class Somatorio
    {
        public void ContaSoma()
        {
            int n, i = 0, soma = 0;
            string digitados = "";
            do
            {
                Console.Write("Digite um número:");
                n = int.Parse(Console.ReadLine());
                if(n > 0)
                {
                    digitados += n + ", ";
                    soma += n;
                    i++;
                }
            }
            while (n > 0);
            Console.WriteLine("Médias dos Valores: {0}", soma / i);
            Console.WriteLine("Números digitados: {0}", digitados);
            Console.WriteLine("Quantidade de números digitados: {0}", i);
            Console.WriteLine("Soma total: {0}", soma);
        }
    }
}
