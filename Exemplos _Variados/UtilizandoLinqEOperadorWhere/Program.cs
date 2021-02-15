using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoLinqEOperadorWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaAlunos = new List<Aluno>()
            {
                new Aluno("Bruna", 001),new Aluno("Wagner", 005),new Aluno("Mateus", 008),
                new Aluno("Ricardo", 003),new Aluno("Vanessa", 009),new Aluno("Maria", 004),null
            };
            //Percebam que em nossa lista criamos 7 iten, sendo um deles nulo

            var ordenaPorNome = listaAlunos.Where(Aluno => Aluno != null).OrderBy(Aluno => Aluno.Nome);
            //para nosso item nulo não gerar uma excessão, utilizamos o método "Where" que neste caso está filtrando os valores que forem nulos e os ignorando
            foreach (var aluno in ordenaPorNome)
            {
                Console.WriteLine($"Aluno.[{aluno.Nome}]; Num.[{aluno.Numero}] ");
            }

            Console.ReadLine();
        }
    }
}
