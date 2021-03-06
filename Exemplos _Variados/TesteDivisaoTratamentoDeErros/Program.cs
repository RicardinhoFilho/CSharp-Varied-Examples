﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDivisaoTratamentoDeErros
{


    class Program
    {
        static void Main(string[] args)
        {
            Metodo();
            Console.ReadLine();
        }
        //Teste com a cadeia de chamada:
        //Metodo -> TestaDivisao -> Dividir
        private static void Metodo()
        {
            TestaDivisao(2);
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            if (resultado == -1)
            {
                Console.WriteLine("A divisão de 10 por " + divisor + " é impossivel");
            }else
            {
                Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
            }


        }

        private static int Dividir(int numero, int divisor)
        {
            if (divisor == 0)
            {
                return -1;
            }
            return numero / divisor;
        }
    }
}
