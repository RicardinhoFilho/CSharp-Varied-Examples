using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataLimite = new DateTime(2021, 5, 23);
            DateTime dataAtual = DateTime.Now;//CAPTAMOS A DATA ATUAL E O HORÁRIO
            TimeSpan diferenca =(dataLimite - dataAtual); //dataFimPagamento - dataCorrente;
            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            Console.WriteLine(mensagem);
            Console.ReadLine();
        }
    }
}
