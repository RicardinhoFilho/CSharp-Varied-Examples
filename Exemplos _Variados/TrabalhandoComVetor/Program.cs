using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idades = new int[5];
            idades[0] = 20;
            idades[1] = 18;
            idades[2] = 29;
            idades[3] = 30;
            idades[4] = 28;

            /*
             for (int i = 0; i < idades.Length; i++)
             {
                readline(idades[i]);
             }
             */

            int aux = 0;

            for (int i = 0; i < idades.Length; i++)
            {
                Console.WriteLine(" Idade " + "[" + i + "] = " + idades[i]);
                
                aux += idades[i];
            }

            double med = (aux / idades.Length);

            Console.WriteLine("Média = " + med);

            Console.ReadLine();
        }
    }
}
