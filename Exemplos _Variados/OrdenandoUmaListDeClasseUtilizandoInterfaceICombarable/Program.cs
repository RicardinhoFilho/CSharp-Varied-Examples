using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenandoUmaListDeClasseUtilizandoInterfaceICombarable
{
    class Program
    {
        static void Main(string[] args)
        {
            //em nossa classe aluno passamos a interface ICromparable e implementamos as regras de ordernação
            var listaDeAlunos = new List<Aluno>()
            {
                new Aluno(90204465,"Alice"),
                new Aluno(20205564,"Jorge"),
                new Aluno(22205563,"Wagner"),
                new Aluno(88205565,"Ricardo"),
                new Aluno(12320556,"Henrrique")
            };
            Console.WriteLine("Antes da ordenação: ");

            foreach (var aluno in listaDeAlunos)
            {
                Console.WriteLine($"id:{aluno._id} nome:{aluno._nome}");
            }
            Console.ReadLine();

            Console.WriteLine("Após Ordenação: ");

            listaDeAlunos.Sort();

            foreach (var aluno in listaDeAlunos)
            {
                Console.WriteLine($"id:{aluno._id} nome:{aluno._nome}"); ;
            }

            Console.ReadLine();
        }
    }
}
