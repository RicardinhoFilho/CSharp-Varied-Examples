using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionandoExtesõesAClasseListGenerica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Neste exemplo criamos uma extensão genérica "ListExtensoens" e com isso podemos uytiliza-las
             independentemente do tipo de nossas listas(string, double,int) */
            Console.WriteLine("Utilizando nossas extensões genéricas para uma lista do tipo 'double'");
            List<double> notas = new List<double>();

            notas.AdicionarVarios(6.4, 4.7, 10, 5.5, 8.3, 5.2, 3);
            notas.EscreveListaNaTela();

            Console.ReadLine();

            Console.WriteLine("Utilizando nossas extensões genéricas para uma lista do tipo 'string'");
            List<string> alunos = new List<string>();

            alunos.AdicionarVarios("Mateus", "Henrrique", "Carlos", "Vanessa");
            alunos.EscreveListaNaTela();

            Console.ReadLine();
        }
    }
}
