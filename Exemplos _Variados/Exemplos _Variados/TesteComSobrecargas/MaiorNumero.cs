using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos__Variados.TesteComSobrecargas
{
    class MaiorNumero
    {
        public double Maior(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }

        public double Maior(double a, double b, double c)
        {

            return Maior(Maior(a, b), c);
            
        }
    }
}
