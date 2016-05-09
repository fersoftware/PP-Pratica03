using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar um programa em C# que apresente como resultado o valor de uma
 * potência de uma base qualquer elevada a um expoente qualquer, ou seja, de BE,
 * em que B é o valor da base e E o valor do expoente. Considere apenas a entrada
 * de valores inteiros e positivos. Por exemplo: B = 2 e E = 5. O programa deverá
 * calcular e exibir o valor de 25 = 32.
*/

namespace PP_Pratica03
{
    class Potencia
    {
        public void PotenciaBase()
        {
            int B = 0, n, E = 0, S = 1;
            do
            {
                Console.Write("Digite a Base: ");
                B = int.Parse(Console.ReadLine());
                if (B < 0 || !int.TryParse(B.ToString(), out n)) Console.WriteLine("Base Inválida");
            } while (B < 0 || !int.TryParse(B.ToString(), out n));

            do
            {
                Console.Write("Digite o Expoente: ");
                E = int.Parse(Console.ReadLine());
                if (E < 0 || !int.TryParse(B.ToString(), out n)) Console.WriteLine("Expoente Inválido");
            } while (E < 0 || !int.TryParse(B.ToString(), out n));

            for (int i = 0; i < E; i++)
            {
                S *= B;
            }

            Console.WriteLine("{0}{1} = {2}",B,E,S);            
        }
    }
}
