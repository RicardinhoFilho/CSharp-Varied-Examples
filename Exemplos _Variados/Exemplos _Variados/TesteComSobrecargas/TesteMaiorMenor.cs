using Exemplos__Variados.TesteComSobrecargas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos__Variados
{
    class TesteMaiorMenor
    {
        static void Main(string[] args)
        {
            MaiorNumero maior = new MaiorNumero();

            Console.WriteLine(maior.Maior(1, 5,3));

            Console.ReadLine();
        }
    }
}
