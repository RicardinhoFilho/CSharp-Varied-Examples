using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenandoListComMetodoSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando lista de inteiros");
            var listaIdades = new List<int>()  //criando lista
            {
                46,57,88,21,16,50,11,78,44
            };

            foreach (var idade in listaIdades) //utilizando foreach para escrever toda a lista na tela
            {
                Console.WriteLine(idade);
            }

            Console.ReadLine();

            Console.WriteLine("Ordenando lista de inteiros");

            listaIdades.Sort();//utilizando método "Sort" que é uma extensão de list para ordenar nossos inteiros

            foreach (var idade in listaIdades)//escrevendo todos os inteiros na tela
            {
                Console.WriteLine(idade);
            }

            Console.ReadLine();

            Console.WriteLine("CRIANDO LISTA DE STRINGS");
            var listaNomes = new List<string>()
            {
                "Barbara","Mateus","Sandra","Adroaldo","Junior","Rafael","Carlos"
            };

            foreach (var nome in listaNomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadLine();

            Console.WriteLine("ORDENANDO LISTA DE STRINGS");
            listaNomes.Sort();
            foreach (var nome in listaNomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadLine();
        }
    }
}
