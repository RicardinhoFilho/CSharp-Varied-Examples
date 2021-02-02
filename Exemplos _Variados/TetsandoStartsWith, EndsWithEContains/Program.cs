using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetsandoStartsWith__EndsWithEContains
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "The Fox end the Hound";

            //TESTE StartsWith
            Console.WriteLine(frase.StartsWith("The"));
            Console.WriteLine(frase.StartsWith("THE"));

            //TESTE EndsWith
            Console.WriteLine(frase.EndsWith("Hound"));
            Console.WriteLine(frase.EndsWith("hound"));

            //TESTE Contains
            Console.WriteLine(frase.Contains("Hound"));
            Console.WriteLine(frase.Contains("hound"));

            Console.WriteLine(frase.Contains("The"));
            Console.WriteLine(frase.Contains("THE"));

            Console.WriteLine(frase.Contains("end"));
            Console.WriteLine(frase.Contains("eNd"));

            Console.ReadLine();
        }
    }
}
