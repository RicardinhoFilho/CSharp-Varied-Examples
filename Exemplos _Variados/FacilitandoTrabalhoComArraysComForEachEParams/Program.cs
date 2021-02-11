using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacilitandoTrabalhoComArraysComForEachEParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando e utilizando o método da forma comum:");
            int[] vetorDeNumeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//percebam que precisamos antes de passarmos nossos itens por parametro criar um vetor com estes itens
            Console.WriteLine(Somador(vetorDeNumeros));
            Console.ReadLine();

            Console.WriteLine("Criando e utilizando o método de forma simplificada:");
            Console.WriteLine(SomadorSimplificado(1,2,3,4,5,6,7,8,9,10));//percebam que ao invés de criarmos um vetor para depois passarmos este vetor por parametrô estamos passando nosso itens diretamente por parametro 

            Console.ReadLine();
        }

        static int Somador(int[] numeros)
        {
            int contador = 0;

            /*for (int i = 0; i < numeros.Length; i++)
            {
                contador += numeros[i];
            }*/

            foreach (int numero in numeros)//ao invés de utilizarmos o for padrão utilizamos o recurso "foreach" que é muito mais simples.
            {
                contador += numero;
            }
            return contador;
        }

        static int SomadorSimplificado(params int[] numeros)
        {
            int contador = 0;
            foreach (int numero in numeros)
            {
                contador += numero;
            }

            return contador;
        }
    }

    
}
