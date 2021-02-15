using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoOrderByComExpressoesLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            var aluno1 = new Aluno("Maria", 008);
            var aluno2 = new Aluno("João", 005);
            var aluno3 = new Aluno("Alfredo", 002);
            var aluno4 = new Aluno("Renan", 003);
            var aluno5 = new Aluno("Ana", 006);
            List<Aluno> listaDeAluno = new List<Aluno>()
            {
                aluno1,aluno2,aluno3,aluno4,aluno5
            };
            //Após a criação de nossa lista vamos escreve-la em nossa tela por ordem de inclusão
            foreach (var alunoAtual in listaDeAluno)
            {
                Console.WriteLine($"Id.[{alunoAtual.Numero}]; Nome.[{alunoAtual.Nome}];");
            }

            Console.ReadLine();
            //utilizando o método Sort vamos ordenar nossa lista na ordem definida como pdrão na classe Aluno, que é pelo "Nome"
            listaDeAluno.Sort();

            foreach (var alunoAtual in listaDeAluno)
            {
                Console.WriteLine($"Id.[{alunoAtual.Numero}]; Nome.[{alunoAtual.Nome}];");
            }

            Console.ReadLine();

            //Agora iremos ordenar pelo identificador
            //listaDeAluno.OrderBy(Aluno => Aluno.Numero);

            IOrderedEnumerable<Aluno> alunosOrdenadosPorNumero = listaDeAluno.OrderBy(Aluno => Aluno.Numero);//percebam que diferentemente do método Sort() que é um void, ao utilizarmos o método "orderby" precisamos utilizar a contsrução apresentada nesta linha, pois ao invés de ser um void está função nos retorna um valor do tipo "IOrderedEnumerable" que neste caso chamamos de "alunosOrdenadosPorNumero"

            foreach (var alunoAtual in alunosOrdenadosPorNumero)
            {
                Console.WriteLine($"Id.[{alunoAtual.Numero}]; Nome.[{alunoAtual.Nome}];");
            }

            Console.ReadLine();

            //Abaixo estamos atribuindo notas para nossos alunos
            aluno2.AtribuirNota(8.8);
            aluno3.AtribuirNota(6.0);
            aluno4.AtribuirNota(9.8);
            aluno5.AtribuirNota(7.7);

            //Agora iremos ordenar nossa lista de alunos por nota: 

            IOrderedEnumerable<Aluno> alunosOrdenadosPorNota = listaDeAluno.OrderBy(Aluno => Aluno.Nota);
            foreach (var alunoAtual in alunosOrdenadosPorNota)
            {
                Console.WriteLine($"Id.[{alunoAtual.Numero}]; Nome.[{alunoAtual.Nome}]; Nota.[{alunoAtual.Nota}]");
            }

            Console.ReadLine();

            //Agora iremos adicionar em nossa lista um elemento nulo e ter=ntarmos implementar o orderBy;

            listaDeAluno.Add(null);//Adicionando elemento nulo

            foreach (var alunoAtual in listaDeAluno)
            {
                if (alunoAtual == null)
                {
                    Console.WriteLine("Elemento Nulo!!");
                }
                else
                    Console.WriteLine($"Id.[{alunoAtual.Numero}]; Nome.[{alunoAtual.Nome}];");
            }

            Console.ReadLine();

            // IOrderedEnumerable<Aluno> listaDeAlunosOrdenadosPeloNumero2 = listaDeAluno.OrderBy(Aluno => Aluno.Numero); Desta forma ocorrerá uma excessão lançada por um elemento nulo, para isso iremos tratar este erro
            IOrderedEnumerable<Aluno> listaDeAlunosOrdenadosPeloNumero2 = listaDeAluno.OrderBy(Aluno =>
            {
                if (Aluno == null)
                {
                    return int.MinValue;//Desta forma estamos passando o menor valor inetiro possivel para nosso elemento nulo, deixando ele como o primeiro elemento em nossa Ordenação
                }
                return Aluno.Numero;
            }
            );
            foreach (var alunoAtual in listaDeAlunosOrdenadosPeloNumero2)
            {
                if (alunoAtual == null)
                {
                    Console.WriteLine("Elemento Nulo!!");
                }
                else
                    Console.WriteLine($"Id.[{alunoAtual.Numero}]; Nome.[{alunoAtual.Nome}];");
            }
            Console.ReadLine();
            listaDeAluno.Sort();
            foreach (var alunoAtual in listaDeAluno)
            {
                if (alunoAtual == null)
                {
                    Console.WriteLine("Elemento Nulo!!");
                }
                else
                    Console.WriteLine($"Id.[{alunoAtual.Numero}]; Nome.[{alunoAtual.Nome}];");
            }

            Console.ReadLine();
        }
    }
}
