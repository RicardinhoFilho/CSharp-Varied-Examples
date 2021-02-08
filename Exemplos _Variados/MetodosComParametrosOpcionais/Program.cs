using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosComParametrosOpcionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Como criar um método com paramêtros opcionais(também servem para construtores)");

            double resultado = somarEDefinirMedia();
            int numeroInicial;
            int tamanhoVetor;

            Console.WriteLine($"Resultado com valores padrões = {resultado}");
            
            numeroInicial = 3;
            resultado = somarEDefinirMedia(numeroInicial);
            Console.WriteLine($"Resultado modificando´número inicial para {numeroInicial} = {resultado}");

            tamanhoVetor = 20;
            resultado = somarEDefinirMedia(tamanhoDoVetor: tamanhoVetor);
            Console.WriteLine($"Resultado modificando somente o tamanho do vetor para {tamanhoVetor} = {resultado}");

            tamanhoVetor = 5;
            numeroInicial = 100;
            resultado = somarEDefinirMedia(numeroInicial, tamanhoVetor);
            Console.WriteLine($"Resultado modificando o tamanho do vetor para {tamanhoVetor} e o numero inicial para {numeroInicial} = {resultado}");

            Console.Read();
        }

        static double somarEDefinirMedia(int numInicial = 1, int tamanhoDoVetor = 10)
        {
            int i;
            double aux = 0;

            int[] vet = new int[tamanhoDoVetor];

            for ( i = 0; i < vet.Length; i++)//preenche o vetor começando pelo valor inicial que por padrão é 1
            {
                vet[i] = numInicial + i;

               // Console.WriteLine("Primeiro Valor" + vet[i]);
            }
            
            for ( i = 0; i < vet.Length; i++)//faz a soma 
            {
                aux += vet[i];
            }

            return (aux/vet.Length);
        }
    }
}
