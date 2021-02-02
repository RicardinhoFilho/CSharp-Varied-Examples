using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Professor Gustavo Silva";

            if (string.IsNullOrEmpty(texto))//se a string for nula ou vazia 
            {
                Console.WriteLine("String vazia");
            }

            Int32 indice = texto.IndexOf("Gustavo");//procurar na string texto a partir da palavra Gustavo
            String texto2 = texto.Substring(indice);//estamos agora coletando somente a partir da palavra no texto que tem Gustavo
            Console.WriteLine("Tamanho: " + texto.Length);//coletando o tamanho do texto com o método Length
            Console.WriteLine("Indice: " + indice);//imprimindo o indice de "Gustavo"
            Console.WriteLine("tEXTO 1: " + texto);//imprimindo texto padrão 
            Console.WriteLine("Texto 2: " + texto2);//excrevemos texto 2 a partir da palavra gustavo


            Console.ReadLine();
        }
    }
}
