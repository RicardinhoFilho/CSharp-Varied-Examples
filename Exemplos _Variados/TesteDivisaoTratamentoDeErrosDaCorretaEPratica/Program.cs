using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDivisaoTratamentoDeErrosDaCorretaEPratica
{
    class Program
    {
       
         static void Main(string[] args)
         {
             Metodo();
             Console.Read();
         }
         private static void Metodo()
         {
             TestaDivisao(2);
             TestaDivisao(0);
         }
         private static void TestaDivisao(int divisor)
         {
             try
             {
                 int resultado = Dividir(10, divisor);
                 Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
             }
             catch (DivideByZeroException e)
             {
                 Console.WriteLine(e.Message);

             }

         }
         private static int Dividir(int numero, int divisor)
         {

             return numero / divisor;
         }
    }
}

