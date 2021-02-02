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
            string url = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDEstino=dolar";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(url);
            string valor = (extrator.GetValor("moeda"));
            Console.WriteLine("Valor da moeda Destino: " + valor);

            valor = (extrator.GetValor("moedaOrigem"));
            Console.WriteLine("Valor da moeda Origem : " + valor);
            
            Console.ReadLine();
        }
    }
}

















/*          DateTime dataLimite = new DateTime(2021, 5, 23);
            DateTime dataAtual = DateTime.Now;//CAPTAMOS A DATA ATUAL E O HORÁRIO
            TimeSpan diferenca =(dataLimite - dataAtual); //dataFimPagamento - dataCorrente;
            string mensagem = "Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca);
            Console.WriteLine(mensagem);*/
