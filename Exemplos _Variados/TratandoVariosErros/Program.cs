using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TratandoVariosErros
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = Math.Pow(5, 2);
            
            Console.WriteLine(num1);
            
             num1 = Console.Read();

            Console.WriteLine("Este é " + num1);

            Console.ReadLine();
        }
    }
}
