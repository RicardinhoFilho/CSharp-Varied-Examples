using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaPares
{
    class Program
    {
        /*Nosso objetivo é escrever um método SomarNumeros que some os elementos de cada par de um array de números.
         * Por exemplo:

        A chamada SomarNumeros(new int[] { 1, 2, 3, 4 }); produzirá a seguinte saída:

        1+2 = 3
        3+4 = 7COPIAR CÓDIGO
        Contudo, se um array com número ímpar de itens for utilizado, devemos ignorar o último elemento. 
        Por exemplo: 
        a chamada SomarNumeros(new int[] { 1, 2, 3, 4, 5 }); possuirá a mesma saída do caso anterior:

        1+2 = 3
        3+4 = 7*/
        static void Main(string[] args)
        {
            int[] listaDeNumeros = { 1, 2, 3, 4, 5 };
            SomarNumeros(listaDeNumeros);

            Console.ReadLine();
        }

        static void SomarNumeros(int[] numeros)
        {
            for (int i = 0; i < (numeros.Length) - 1; i += 2)
            {
                int primeiroNumero = numeros[i];
                int segundoNumero = numeros[i + 1];

                int soma = primeiroNumero + segundoNumero;

                Console.WriteLine($"{primeiroNumero}+{segundoNumero} = {soma}");
            }
        }
    }
}
