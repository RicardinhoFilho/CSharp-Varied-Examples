using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoToLowerToUperEReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string teste = "Perdiz";
            Console.WriteLine("Palavra inicial: " + teste);
            //Testando Replace
            teste = teste.Replace("P", "p");
            Console.WriteLine("Trocando 'P' por 'p' :" + teste);

            //testando ToUpper
            teste = teste.ToUpper();
            Console.WriteLine("Transformando tudo em maiusculo :" + teste);

            //testando ToLower
            teste = teste.ToLower();
            Console.WriteLine("Transformando tudo em minusculo :" + teste);

            Console.Read();
        }
    }
}
