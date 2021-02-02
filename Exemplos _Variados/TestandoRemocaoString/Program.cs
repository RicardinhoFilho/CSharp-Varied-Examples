using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestandoRemocaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string teste = "primeiraparte&segundaparte";
            int ponto_de_parada = teste.IndexOf("&");
            int ponto_de_partida = teste.IndexOf("primeiraparte");
            string final = teste.Remove(ponto_de_parada);
           
            Console.WriteLine("Ponto de parada: " + ponto_de_parada);
            Console.WriteLine(teste.Substring(ponto_de_partida));
            Console.WriteLine(final);

            //oq acontece se eu tentar extrair index of de uma palavra que não existe em minha frase? 

            int teste2 = teste.IndexOf("nãotemessapalavra");
            Console.WriteLine("Resultado de quando não há a palavra: " + teste2);



            Console.ReadLine();
        }
    }
}
