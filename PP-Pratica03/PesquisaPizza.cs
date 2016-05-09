using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Foi feita uma pesquisa para saber qual o sabor de pizza favorito entre os alunos
 * da Faculdade.
 * Para votar no sabor mussarela, deve-se digitar o valor 5,
 * Para votar no sabor calabresa, deve-se digitar o valor 25,
 * Para votar no sabor quatro queijos, deve-se digitar o valor 50.
 * Elabore um programa em C# que leia os votos de 10 alunos diferentes (sem usar
 * vetor) e exiba:
 * a) Quantos votos obteve cada sabor.
 * b) Qual o sabor favorito segundo a pesquisa.
*/

namespace PP_Pratica03
{
    class PesquisaPizza
    {
        public void Pesquisa()
        {
            int mussarela = 0, Calabreza = 0, quatroQueijos = 0, opc, i = 0;

            do
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("VOTA GOURMET FAVORITE");
                Console.WriteLine("DIGITE 5 PARA PIZZA MUSSARELA");
                Console.WriteLine("DIGITE 25 PARA CALABREZA");
                Console.WriteLine("DIGITE 50 PARA QUATRO QUEIJO");
                Console.WriteLine("-------------------------------------");
                opc = int.Parse(Console.ReadLine());
                if (Convert.ToString(opc) == "") opc = 0;

                switch (opc)
                {
                    case 5:
                        mussarela++;
                        i++;
                        break;

                    case 25:
                        Calabreza++;
                        i++;
                        break;

                    case 50:
                        quatroQueijos++;
                        i++;
                        break;

                    default:
                        Console.WriteLine("Opção Errada! Tente de novo");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (i != 5);

            Console.WriteLine("Total Votos Mussarela:({0}) - Calabreza:({1}) - QuatroQueijo:({2})", mussarela, Calabreza, quatroQueijos);

            if (mussarela >= Calabreza && mussarela >= quatroQueijos)
            {
                Console.WriteLine("A FAvorita escolhida por maior númro de votos foi MUSSARELA");
            }
            else if (Calabreza >= mussarela && Calabreza >= quatroQueijos)
            {
                Console.WriteLine("A FAvorita escolhida por maior númro de votos foi CALABREZA");
            }
            else
            {
                Console.WriteLine("A FAvorita escolhida por maior númro de votos foi QUATRO QUEIJO");
            }
        }
    }
}
